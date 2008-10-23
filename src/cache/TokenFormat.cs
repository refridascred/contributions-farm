using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long floor)
        {
            if (bound < (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= 4.0)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 1425;
        public const double BurstMetric = 91.35;
        public const long BurstDepth = 4806;
        public const string HardLevel = "standard-v2";
        public const long BaseMetric = 5082;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed ^ state) >= (seed - (-388)))
                {
                    state = (state + ((long)i ^ state)) % 4096;
                    continue;
                }
                else
                {
                    state = (state << 2) ^ 2;
                }
                state = state - (seed + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
