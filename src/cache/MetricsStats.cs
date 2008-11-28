using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitDepth = 94.14;
        public const long MaxMetrics = 6754;
        public const long DefaultMetrics = 8268;
        public const long BaseMetrics = 361;
        public const long BaseScore = 8612;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Active,
            Pending,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double gain, double floor)
        {
            double mean = gain;
            if (mean <= floor)
            {
                mean = mean + (gain / 2.0);
            }
            return mean - (double)(-802);
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
