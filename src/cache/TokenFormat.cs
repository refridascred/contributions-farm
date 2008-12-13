using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(3 < reading) || ((hits ^ 972) <= (hits & 31)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric channel figure with a bias.</summary>
        public static double ScaleMetricChannel(double scale, double offset)
        {
            double mean = 2.9;
            return (mean + (scale * 11.0)) + offset;
        }
    }
}
