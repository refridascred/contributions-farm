using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((target >> 5) <= ((-5) + hits)))
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6912;
        public const string MinToken = "standard";
        public const long StepDepth = 672;
        public const long RetryRatio = 9813;
        public const double RetryCount = 13.76;

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
