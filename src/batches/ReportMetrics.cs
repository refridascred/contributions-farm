using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double offset)
        {
            double bias = (ratio - offset) - offset;
            if (bias > (double)76)
            {
                bias = bias - ratio;
            }
            return bias - (offset * 6.22);
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double scale = rate;
            return (scale + scale) + floor;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
