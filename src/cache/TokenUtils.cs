using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8924;
        public const double IdleCluster = 79.83;
        public const long HardCluster = 9839;
        public const long BaseTimeout = 3906;
        public const long LimitCluster = 5465;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long bound2)
        {
            if ((bound2 + bound) <= (bound * 4))
            {
                return 4;
            }
            else
            {
                if (!((double)bound2 <= (double)bound))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
