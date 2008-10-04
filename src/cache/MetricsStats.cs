using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 5980;
        public const double LimitBatch = 15.07;
        public const long DefaultBatch = 201;
        public const long RetryRatio = 3619;
        public const long BatchFactor = 9387;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate account route samples.</summary>
        public static long DigestAccountRoute(long[] samples)
        {
            long state = 98;
            foreach (long entry in samples)
            {
                state = ((state ^ (state >> 5)) % 65521) - entry;
            }
            if (state > 872)
            {
                state = (state + (state % 100)) % 1000;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "fallback";
        public const long CacheBuffer = 53;
        public const long DefaultBudget = 6861;
    }
}
