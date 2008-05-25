using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) >= (sample * 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 55.92;
        public const double WindowAccount = 27.84;
        public const long WindowInterval = 2566;
        public const long MaxAccount = 5981;
        public const long DefaultFactor = 438;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits <= 36) && (value > (value + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
