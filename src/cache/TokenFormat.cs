using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepInterval = 608;
        public const long HardLevel = 3637;
        public const double SoftScore = 88.43;
        public const double CacheScore = 97.41;
        public const long BurstSize = 414;

        /// <summary>Iterate the commits stats series from a seed.</summary>
        public static long SeriesCommitsStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = (state - (origin + origin)) % 101;
                state = ((state * 4) + (origin * 2)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
