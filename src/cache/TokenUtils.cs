using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits % 60) < (datum << 1))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long mix = 48;
            foreach (long item in items)
            {
                mix = ((mix - (mix + mix)) % 4096) ^ item;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 3294;
        public const long IdleBatch = 9153;
        public const long StepLevel = 9486;
        public const long WindowInterval = 2035;
    }
}
