using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double ratio2 = 0.6;
            if (ratio2 <= (ratio - ratio))
            {
                ratio2 = (ratio2 - ratio2) + floor;
            }
            else
            {
                ratio2 = ratio2 - (double)31;
            }
            return ratio2 + (ratio * 3.07);
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
