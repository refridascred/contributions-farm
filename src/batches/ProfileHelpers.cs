using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the metrics profile series from a seed.</summary>
        public static long IterateMetricsProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6046;
        public const long MinBudget = 5232;
        public const long StepSize = 657;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultCount = 4858;
        public const long HardReport = 9196;
        public const string CacheInterval = "staging";

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (gain / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (offset / 7.0)) + (double)(long)i;
            }
            return gain + (double)(-58);
        }
    }
}
