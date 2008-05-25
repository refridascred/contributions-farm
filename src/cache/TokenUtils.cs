using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "staging-1";
        public const long CacheScore = 4625;
        public const long BurstToken = 390;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((-677) > ((long)i + seed))
                {
                    total = (total ^ (seed + total)) % 101;
                }
                if (((-95) + total) < ((long)i * 3))
                {
                    total = (total ^ (seed & 255)) % 1000;
                    total = (total + 16) % 97;
                }
                if ((total + seed) > seed)
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
