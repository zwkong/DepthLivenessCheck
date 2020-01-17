using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthLivenessCheck
{
    public class ViewModel : NotifyPropertyChanged
    {

        private string _depthInfo;

        public string DepthInfo
        {
            get => _depthInfo; 
            set
            {
                _depthInfo = value;
                RaisePropertyChange();
            }
        }

    }
}
