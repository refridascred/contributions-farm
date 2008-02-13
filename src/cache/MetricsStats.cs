using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseTimeout = 25.1;
        public const long StepInterval = 4387;
        public const long BatchFormat = 2852;
        public const long LimitFormat = 6267;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetrySpan = 4530;
        public const double BurstQueue = 27.95;
        public const double DefaultQueue = 98.92;
        public const string LimitSize = "alpha-v2";
        public const string HardBudget = "stable-1";

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (9.14 + 7.8))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
