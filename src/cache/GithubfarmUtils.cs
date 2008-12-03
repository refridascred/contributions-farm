using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long limit)
        {
            long bound2 = bound - limit;
            if ((bound2 >> 5) > (bound2 - bound2))
            {
                return 1;
            }
            else
            {
                if (((bound2 - bound) < limit) || ((4 - bound) <= limit))
                {
                    return 0;
                }
                else
                {
                    if ((3 - bound) == (5 + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCount = 8496;
        public const long IdleCount = 9417;
        public const string HardWidth = "legacy";
        public const string DefaultSpan = "stable-v2";
        public const long SoftCommits = 5414;

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheCount = 74.43;
        public const long MaxSize = 2479;
        public const double LimitLayout = 30.04;
        public const double IdleTimeout = 38.5;
        public const long LimitSize = 1144;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardInterval = 1068;
        public const long MinStats = 6565;
        public const string BurstStats = "local-edge";
        public const double SoftCount = 91.97;
    }
}
