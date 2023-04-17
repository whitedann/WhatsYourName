using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WhatsYourName
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool _textIn = false;
        private bool _someoneIsHere = false;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {

            /** First person goes here **/
            FirstPerson.Text = "Daniel";

            /** Second person goes here **/
            SecondPerson.Text = "";

            /** Third person goes here **/
            ThirdPerson.Text = "";

            /** Fourth person goes here **/
            FourthPerson.Text = "";


            if(FirstPerson.Text == "" && SecondPerson.Text == "" && ThirdPerson.Text == "" && FourthPerson.Text == "")
            {
                SecondPerson.Text = "No one is here! :(";
            }

            var storyBoardIn0 = (Storyboard)this.Resources["slideInLeft0"];
            var storyBoardOut0 = (Storyboard)this.Resources["slideOutLeft0"];
            var storyBoardIn1 = (Storyboard)this.Resources["slideInRight1"];
            var storyBoardOut1 = (Storyboard)this.Resources["slideOutRight1"];
            var storyBoardIn2 = (Storyboard)this.Resources["slideInLeft2"];
            var storyBoardOut2 = (Storyboard)this.Resources["slideOutLeft2"];
            var storyBoardIn3 = (Storyboard)this.Resources["slideInRight3"];
            var storyBoardOut3 = (Storyboard)this.Resources["slideOutRight3"];
            if (_textIn)
            {
                storyBoardOut0.Begin();
                storyBoardOut1.Begin();
                storyBoardOut2.Begin();
                storyBoardOut3.Begin();
                _textIn = false;
            }
            else
            {
                storyBoardIn0.Begin();
                storyBoardIn1.Begin();
                storyBoardIn2.Begin();
                storyBoardIn3.Begin();
                _textIn = true;
            }
        }
    }
}
