using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate stats token readings against a bound.</summary>
        public static bool GuardStatsTokenBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long MaxBudget = 1263;
        public const long CacheSize = 8841;

        /// <summary>Project the next tools githubfarm value.</summary>
        public static double SmoothToolsGithubfarm(double bias, double span)
        {
            double weight = (double)(25 << 3);
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight - (5.06 * 19.0)) + (double)(long)i) + bias) - span;
            }
            return weight - (double)685;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Dropped,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
