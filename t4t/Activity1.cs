using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace t4t
{
    [Activity(Label = "Hello World")]
    public class Activity1 : Activity
    {
        Button btn_Hello;
        protected override void OnCreate(Bundle bundle)
        {
           

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);


            btn_Hello = FindViewById<Button>(Resource.Id.btn_Hello);
            btn_Hello.Click += btn_Hello_Click;

        }


        void btn_Hello_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Tit4Tat App by Timothy Wong", ToastLength.Short).Show();
        }

    }
}