using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class newDelta3 : MetroFramework.Forms.MetroForm
    {
        public newDelta3()
        {
            InitializeComponent();
        }
        private void textBoxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void textBoxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == '-')))
            {
                e.Handled = true;
            }
        }
        private void textBoxc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void limparCampos()
        {
            textBoxa.Clear();
            textBoxb.Clear();
            textBoxc.Clear();
            textBoxx.Clear();
            textBoxxx.Clear();
            textBoxdelta.Clear();
            B2.Text = "";
            A.Text = "";
            C.Text = "";
            newB.Text = "";
            newAC.Text = "";
            valDelta.Text = "";
            bNega.Text = "";
            newDelta4.Text = "";
            newA.Text = "";
            newBBB.Text = "";
            newDeltinha.Text = "";
            DvA.Text = "";
            BbB.Text = "";
            del.Text = "";
            newad.Text = "";
            resultX.Text = "";
            aaa.Text = "";
            lbaaaa.Text = "";
            b1.Text = "";
            a1.Text = "";
            r1.Text = "";
            r2.Text = "";
            d22.Text = "";
            rs2.Text = "";

            lbDeltaaa.Visible = false;
            newDeltinha.Visible = false;
            newDelta4.Visible = false;
            lbDeltaaa.Visible = false;
            label4.Visible = false;
            B2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            A.Visible = false;
            label7.Visible = false;
            C.Visible = false;
            lbDelta2.Visible = false;
            label8.Visible = false;
            newB.Visible = false;
            label9.Visible = false;
            newAC.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            valDelta.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            bNega.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            newA.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            newBBB.Visible = false;
            label23.Visible = false;
            DvA.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            BbB.Visible = false;
            label26.Visible = false;
            del.Visible = false;
            label27.Visible = false;
            newad.Visible = false;
            label28.Visible = false;
            resultX.Visible = false;
            label29.Visible = false;
            aaa.Visible = false;
            label30.Visible = false;
            lbaaaa.Visible = false;
            rs2.Visible = false;
            label32.Visible = false;
            d22.Visible = false;
            label34.Visible = false;
            r2.Visible = false;
            label36.Visible = false;
            r1.Visible = false;
            label38.Visible = false;
            a1.Visible = false;
            label40.Visible = false;
            b1.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
        }
        private void buttoncalcula_Click(object sender, EventArgs e)
        {
            if(textBoxa.Text == "" || textBoxb.Text == "" || textBoxc.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos!");
            }
            else
            {
                int aa, bb, cc;
                double delta, x, xx;

                aa = Convert.ToInt32(textBoxa.Text);
                bb = Convert.ToInt32(textBoxb.Text);
                cc = Convert.ToInt32(textBoxc.Text);

                delta = (Math.Pow(bb, 2)) - (4 * aa * cc);

                if (delta >= 0)
                {
                    x = ((-bb + Math.Sqrt(delta)) / (2 * aa));
                    xx = ((-bb - Math.Sqrt(delta)) / (2 * aa));

                    textBoxx.Text = x.ToString();
                    textBoxxx.Text = xx.ToString();

                    textBoxdelta.Text = delta.ToString();

                    newDeltinha.Visible = true;
                    newDelta4.Visible = true;
                    lbDeltaaa.Visible = true;
                    labela.Visible = true;
                    labelb.Visible = true;
                    labelc.Visible = true;
                    textBoxa.Visible = true;
                    textBoxb.Visible = true;
                    textBoxc.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    textBoxx.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    B2.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    A.Visible = true;
                    label7.Visible = true;
                    C.Visible = true;
                    lbDelta2.Visible = true;
                    label8.Visible = true;
                    newB.Visible = true;
                    label9.Visible = true;
                    newAC.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    valDelta.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    bNega.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    newA.Visible = true;
                    label21.Visible = true;
                    label22.Visible = true;
                    newBBB.Visible = true;
                    label23.Visible = true;
                    DvA.Visible = true;
                    label24.Visible = true;
                    label25.Visible = true;
                    BbB.Visible = true;
                    label26.Visible = true;
                    del.Visible = true;
                    label27.Visible = true;
                    newad.Visible = true;
                    label28.Visible = true;
                    resultX.Visible = true;
                    label29.Visible = true;
                    aaa.Visible = true;
                    label30.Visible = true;
                    lbaaaa.Visible = true;
                    rs2.Visible = true;
                    label32.Visible = true;
                    d22.Visible = true;
                    label34.Visible = true;
                    r2.Visible = true;
                    label36.Visible = true;
                    r1.Visible = true;
                    label38.Visible = true;
                    a1.Visible = true;
                    label40.Visible = true;
                    b1.Visible = true;
                    label42.Visible = true;
                    label43.Visible = true;
                    label44.Visible = true;
                    label31.Visible = true;

                    B2.Text = Convert.ToString("(" + bb + ")²");
                    A.Text = Convert.ToString("(" + aa);
                    C.Text = Convert.ToString(cc + ")");
                    newB.Text = Convert.ToString(Math.Pow(bb, 2));
                    newAC.Text = Convert.ToString("(" + -4 * aa * cc + ")");
                    valDelta.Text = Convert.ToString(delta);
                    bNega.Text = Convert.ToString("(" + bb + ")");
                    newDelta4.Text = Convert.ToString(delta);
                    newA.Text = Convert.ToString(aa);
                    newBBB.Text = Convert.ToString(-(bb));
                    newDeltinha.Text = Convert.ToString(delta);
                    DvA.Text = Convert.ToString(2 * aa);

                    BbB.Text = Convert.ToString(-(bb));
                    del.Text = Convert.ToString(delta);
                    newad.Text = Convert.ToString(2 * aa);

                    double dd2 = Convert.ToDouble(BbB.Text);
                    double dd3 = Convert.ToDouble(del.Text);
                    resultX.Text = Convert.ToString(dd2 + dd3);

                    aaa.Text = Convert.ToString(2 * aa);
                    lbaaaa.Text = Convert.ToString(Math.Round(x, 2));
                    b1.Text = Convert.ToString(-(bb));
                    a1.Text = Convert.ToString(delta);
                    r1.Text = Convert.ToString(2 * aa);

                    r2.Text = Convert.ToString(-(bb) - delta);
                    d22.Text = Convert.ToString(2 * aa);

                    double ads = Convert.ToDouble(r2.Text);
                    double ads2 = Convert.ToDouble(d22.Text);
                    rs2.Text = Convert.ToString(Math.Round(xx, 2));
                }
                else
                {
                    MessageBox.Show("Essa equação não possui raízes reais !");
                }
            }        
        }
        private void buttonlimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Confirma Limpar campo?"), "Bhaskara 1.0", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                limparCampos();
            }
            else
            {
            }
        }
        private void buttonsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBoxdelta_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmBhaskara_Load(object sender, EventArgs e)
        {

        }
        private void textBoxx_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
