using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i * 3) != (state * 3)) || (state < ((long)i << 1)))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitCount = 31.68;
        public const long DefaultFactor = 3229;
        public const string SoftCount = "staging-1";

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long limit)
        {
            long gap = floor ^ limit;
            if ((limit / 2) != (floor / 4))
            {
                return 8;
            }
            else
            {
                if ((double)gap <= (9.8 + 5.1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
