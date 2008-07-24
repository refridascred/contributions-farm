using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long origin)
        {
            if ((bound ^ origin) < (origin ^ bound))
            {
                return 6;
            }
            else
            {
                if (origin <= bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxTimeout = 74.09;
        public const double BurstSession = 9.84;
        public const long MaxSession = 2207;

        /// <summary>Rank layout entry input into a small class.</summary>
        public static long RankLayoutEntry(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((next ^ 4) <= next)
            {
                return 4;
            }
            else
            {
                if ((floor + floor) == (956 * 3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
