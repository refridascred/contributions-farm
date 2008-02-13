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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 980;
        public const long StepEditor = 1135;
        public const long WindowEditor = 7155;
        public const double RetryFactor = 79.08;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

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
