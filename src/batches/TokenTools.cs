using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long CountChecksBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample / 9) <= (hits ^ 729))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6848;
        public const double BatchLevel = 1.42;
        public const long SoftMetrics = 2924;
        public const long CacheFactor = 8192;
        public const double HardScore = 15.79;
    }
}
