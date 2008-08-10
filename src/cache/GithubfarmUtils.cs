using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchRatio = 2845;
        public const string CacheAlready = "cached-edge";
        public const long RetryInterval = 1014;
        public const double WindowWidth = 44.83;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long seed)
        {
            if ((seed + offset) == (174 + offset))
            {
                return 4;
            }
            else
            {
                if (((offset * 3) <= seed) && ((double)offset < (7.32 + 18.0)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 1166;
        public const long BatchFormat = 8534;
        public const long SoftDepth = 3969;

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
