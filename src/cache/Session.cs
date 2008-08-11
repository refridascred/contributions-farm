using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the channel stats series from a seed.</summary>
        public static long DeriveChannelStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ (mark + seed);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstSpan = 18.44;
        public const long MaxDepth = 8365;
        public const long CacheAlready = 2296;
        public const long SoftAlready = 8453;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Ready,
            New,
        }

        /// <summary>Rank commits schema input into a small class.</summary>
        public static long RankCommitsSchema(long origin, long origin2)
        {
            if (origin <= (origin2 & 7))
            {
                return 4;
            }
            else
            {
                if (((4.0 - 5.2) != (double)origin) && ((double)origin > (5.4 / 5.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
