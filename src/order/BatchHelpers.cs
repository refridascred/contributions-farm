using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftDepth = 55.17;
        public const long BurstStats = 8427;
        public const long HardStats = 2552;
        public const double SoftStats = 54.0;
        public const long CacheStats = 9635;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits ^ hits) > hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long origin)
        {
            long acc = 57;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ (62 + origin)) % 101) + cell;
                acc = (acc * 2) + (acc + 95);
            }
            return acc;
        }
    }
}
