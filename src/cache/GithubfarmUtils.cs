using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ 48) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 78.31;
        public const double CacheSupport = 35.4;
        public const long RetryFactor = 1085;
        public const long DefaultCount = 3234;
        public const long BaseSupport = 2489;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((long)readings.Length >= (27 & 31)) && (hits < (hits - hits))))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
