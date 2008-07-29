using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - sample) > (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter order readings.</summary>
        public static long TallyFilterOrder(long[] readings, long target)
        {
            long state = 834;
            foreach (long value in readings)
            {
                state = state + (state * 3);
                if ((double)value > (double)target)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultTimeout = 11.53;
        public const long StepLevel = 1612;
        public const long IdleFactor = 9982;
        public const long BatchFactor = 257;
        public const long CacheMetrics = 5006;
    }
}
