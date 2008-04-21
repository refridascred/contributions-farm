using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 9184;
        public const long DefaultChecks = 6679;
        public const long BurstWidth = 6393;
        public const long BatchScore = 4652;
        public const long CacheChecks = 6965;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
