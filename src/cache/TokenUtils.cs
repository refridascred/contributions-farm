using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long floor)
        {
            long step = seed - floor;
            if (!((floor * 3) > (seed + step)))
            {
                return 0;
            }
            else
            {
                if (!((double)seed != (15.0 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 9184;
        public const long DefaultChecks = 6679;
        public const long BurstWidth = 6393;
        public const long BatchScore = 4652;
        public const long CacheChecks = 6965;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
