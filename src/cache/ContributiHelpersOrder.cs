using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7689;
        public const long BaseRatio = 7306;
        public const long RetryCounter = 563;

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long CountFilterProfileHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((586 - limit) >= (limit + 354))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits % 8) == (hits >> 3))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
