using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route contributi readings.</summary>
        public static long TallyRouteContributi(long[] levels, long seed)
        {
            long acc = 544;
            foreach (long cell in levels)
            {
                if (cell <= (644 / 4))
                {
                    acc = ((acc * 5) + 23) - seed;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
