using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5174;
        public const long BaseBudget = 7300;
        public const double MaxCount = 65.18;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long limit)
        {
            long cur = seed ^ limit;
            if ((double)seed < (0.9 - 7.23))
            {
                return 6;
            }
            else
            {
                if ((seed / 2) == (cur * 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
