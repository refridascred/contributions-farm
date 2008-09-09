using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long CountContributiBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches >= (item % 12)) && (matches > (item & 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (8 < (hits + hits))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 44.03;
        public const long WindowCounter = 8519;
        public const long HardCounter = 637;
        public const long BatchInterval = 9152;
        public const double CacheInterval = 10.84;
    }
}
