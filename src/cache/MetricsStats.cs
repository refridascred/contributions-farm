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

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items, long limit)
        {
            long total = 980;
            foreach (long reading in items)
            {
                if (reading > (reading << 1))
                {
                    total = ((total + (total - 1)) % 101) - limit;
                }
            }
            if (total > (-203))
            {
                total = (total ^ (total * 5)) % 97;
            }
            return total;
        }
    }
}
