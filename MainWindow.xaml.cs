using System.Windows;
using System.Collections.Generic;

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            InitializeComponent();

            List<MyData> list = new List<MyData>();

            list.Add(new MyData { UserName = "fuck", ClassName = "Fuck" });

            list.Add(new MyData { UserName = "you", ClassName = "You" });

            DataList.ItemsSource = list;
        }
    }

    public class MyData { 
        
        public string UserName { get; set; }

        public string ClassName { get; set; }


    }
}
