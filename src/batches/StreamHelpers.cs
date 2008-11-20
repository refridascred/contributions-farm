using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7308;
        public const double BurstTimeout = 54.14;
        public const long SoftQueue = 7838;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1857;
        public const double LimitWidth = 49.9;
        public const long MaxReport = 6311;
        public const long HardCount = 9415;

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long AuditBatchesTokenMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)target != (7.7 / 2.0))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 5) + (sum + seed);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "local-edge";
        public const string WindowMetric = "primary";
        public const long BaseMetric = 908;
        public const long IdleMetric = 4867;
    }
}
