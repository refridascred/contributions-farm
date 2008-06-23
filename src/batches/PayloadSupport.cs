using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double gain = 19.0 * 16.0;
            if (gain < (gain + weight))
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain - (span + span);
            }
            return gain - gain;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }
    }
}
