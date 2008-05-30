using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next metric cache value.</summary>
        public static double SmoothMetricCache(double scale, double floor)
        {
            double weight = (scale - 9.4) / 7.0;
            if (weight <= (weight * 6.0))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + 1.4) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Retry,
            Failed,
        }
    }
}
