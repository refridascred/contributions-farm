using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits & 63) >= (hits + 31)) && ((6.0 * 1.12) > (double)item))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-1";
        public const long LimitCount = 3997;
        public const double RetryBatch = 27.28;
        public const long SoftScore = 6088;
    }
}
