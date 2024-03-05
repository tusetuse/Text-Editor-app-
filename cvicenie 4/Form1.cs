namespace cvicenie_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        bool change = false;
        string way = "";

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (change == true)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Do you want to save the file ?",
                    "Text editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text file (*.txt)|.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        TextWriter tw = new StreamWriter(sfd.FileName);
                        try
                        {
                            tw.Write(textBox1.Text);
                            tw.Close();
                            textBox1.Text = "";
                            way = "";
                            change = false;
                        }
                        catch
                        {

                        }
                    }
                }
                else if (dr == DialogResult.No)
                {
                    way = "";
                    textBox1.Text = "";
                    change = false;
                }
                else if (dr == DialogResult.Cancel)
                {
                    /*Zemlovka, also known as Zemlbaba, is a traditional Slovak and Czech dessert that is a type of bread pudding. It combines slices of bread or rolls (often older, to avoid waste) with apples, eggs, milk, and sometimes raisins or nuts, all baked together to create a sweet, comforting dish. Here's a basic recipe for Zemlovka:
                    
                    Ingredients:
                    6-8 cups of day-old white bread or rolls, cut into slices or cubes
                    4-5 apples, peeled, cored, and thinly sliced
                    1/2 cup of raisins (optional)
                    4 eggs
                    1 cup of milk
                    1 cup of heavy cream
                    3/4 cup of granulated sugar, plus more for sprinkling on top
                    2 teaspoons of vanilla extract
                    1 teaspoon of ground cinnamon, plus more for sprinkling on top
                    Powdered sugar for dusting (optional)
                    Butter for greasing the baking dish
                    Instructions:
                    Preheat Oven and Prepare Baking Dish:
                    
                    Preheat your oven to 350°F (175°C). Grease a large baking dish with butter.
                    Layer Bread and Apples:
                    
                    Begin with a layer of bread slices or cubes at the bottom of the dish. Follow with a layer of apple slices. If using, sprinkle some raisins over the apples. Repeat the layers until all the bread and apples are used, ending with a layer of apples on top.
                    Mix Eggs, Milk, Cream, and Seasonings:
                    
                    In a large bowl, beat the eggs with the milk, heavy cream, granulated sugar, vanilla extract, and ground cinnamon until well combined.
                    Pour Liquid Mixture Over Layers:
                    
                    Pour the egg and milk mixture evenly over the bread and apples in the baking dish, allowing the liquid to soak into the bread. Let it sit for a few minutes to absorb.
                    Add Final Touches:
                    
                    Sprinkle the top layer with a little more granulated sugar and cinnamon to create a crispy, flavorful crust as it bakes.
                    Bake:
                    
                    Bake in the preheated oven for about 45-55 minutes, or until the top is golden brown and the center is set.
                    Cool and Serve:
                    
                    Let the Zemlovka cool slightly before serving. Dust with powdered sugar if desired. It can be served warm or at room temperature.
                    Enjoy your Zemlovka as a delightful end to a meal or as a sweet treat any time of the day. It's a delicious way to use up leftover bread and enjoy the flavors of apples and cinnamon combined in a warm, comforting dessert.*/
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text file (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextReader tr = new StringReader(ofd.FileName);
                textBox1.Text = tr.ReadToEnd();
                tr.Close();
            }
            else if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                /*Goulash (gulyás in Hungarian) is a famous Hungarian stew known for its rich flavors, primarily featuring meat, vegetables, and paprika. The dish varies from region to region and can range from a soup to a thicker stew. Here's a basic recipe for making Hungarian Goulash:

                Ingredients:
                    2 tablespoons vegetable oil
                 2 medium onions, chopped
                 2 cloves of garlic, minced
                 2 pounds beef stew meat(such as chuck), cut into 1 - inch cubes
                 2 - 3 tablespoons Hungarian paprika(sweet or hot, depending on preference)
                 4 cups beef broth or water
                 2 medium carrots, peeled and sliced
                 2 medium parsnips, peeled and sliced(optional)
                 2 medium potatoes, peeled and cut into 1 - inch cubes
                 1 bell pepper, chopped (optional)
                 2 tomatoes, peeled and chopped, or 1 can of diced tomatoes(optional)
                 1 teaspoon caraway seeds(optional)
                 Salt and pepper to taste
                 Fresh parsley, chopped(for garnish)
                                 Instructions:
                                     Brown the Meat:

                                 Heat the oil in a large pot over medium - high heat.Add the onions and garlic, and sauté until the onions are translucent.
                 Add the beef cubes and brown them on all sides.
                 Add Paprika:

                 Lower the heat to medium and add the paprika, stirring quickly to coat the meat and onions. Be careful not to burn the paprika.
                 Add Liquids:

                 Pour in the beef broth or water.Stir well, scraping any browned bits off the bottom of the pot.
                 Simmer:

                 Bring to a simmer, then reduce the heat to low.Cover and let it cook for about 1 hour, or until the meat starts to get tender.
                 Vegetables:

                 Add the carrots, parsnips(if using), potatoes, bell pepper(if using), tomatoes (if using), and caraway seeds(if using). Season with salt and pepper to taste.
                 Bring back to a simmer, then cover and cook for another 30 - 40 minutes, or until the vegetables and meat are very tender.
                 Final Adjustments:

                 Taste and adjust the seasoning with more salt, pepper, or paprika as needed.The goulash should be a thick, hearty stew.If it's too thick, you can add a bit more broth or water; if too thin, simmer uncovered to reduce.
                 Serve:

                 Garnish with fresh parsley before serving.Goulash is traditionally served with bread or dumplings on the side.
                 Enjoy your meal! This goulash recipe is a hearty, comforting dish perfect for cold days or whenever you want a taste of Hungarian cuisine.*/
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (way == "")
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else if (way != "")
            {
                TextWriter tw = new StreamWriter(way);
                try
                {
                    tw.Write(textBox1.Text);
                    tw.Close();
                }
                catch
                {
                    MessageBox.Show("Write error!!!, Text editor");
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(sfd.FileName);
                try
                {
                    tw.Write(textBox1.Text);
                    tw.Close();
                    way = sfd.FileName;
                }
                catch
                {
                    MessageBox.Show("Write error!!!, Text editor");
                }
            }

            else if (way != "")
            {
                TextWriter tw = new StreamWriter(way);
                try
                {
                    tw.Write(textBox1.Text);
                    tw.Close();
                }
                catch
                {
                    MessageBox.Show("Write error!!!, Text editor");
                }
            }
        }

        private void textStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fd.Font;
            }
            else
            {
                textBox1.Font = new Font("Comic Sans MS", 15f);
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = cd.Color;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = cd.Color;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            change = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Comic Sans MS", 15f);
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
        }

        private bool isClosingByTimer = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosingByTimer)
            {
                pictureBox1.Visible = true;
                e.Cancel = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            isClosingByTimer = true;
            this.Close();
        }
    }
}