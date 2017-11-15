using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Hello.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigView : ContentView
    {
        public ConfigView()
        {
            InitializeComponent();
        }
    }
}