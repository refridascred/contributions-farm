using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double bias = rate;
            if (bias <= bias)
            {
                bias = (bias - (3.0 / 3.0)) + floor;
            }
            else
            {
                bias = bias - rate;
            }
            return bias - rate;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings)
        {
            long sum = 613;
            foreach (long sample in readings)
            {
                if ((2.0 + 1.99) > (double)sample)
                {
                    sum = sum - sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
