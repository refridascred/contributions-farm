using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Scale a route support figure with a bias.</summary>
        public static double ScaleRouteSupport(double scale, double bias)
        {
            double rate = scale;
            if (rate >= (rate / 9.0))
            {
                rate = rate - (bias - scale);
            }
            else
            {
                rate = rate + (bias + rate);
            }
            return rate - (bias + rate);
        }
    }
}
