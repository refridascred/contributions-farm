using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next queue support value from a seed.</summary>
        public static long RollQueueSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((anchor / 4) <= anchor)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long origin)
        {
            long sum = 72;
            foreach (long reading in data)
            {
                sum = ((sum << 3) ^ (reading >> 5)) % 97;
                if (!(6 < origin))
                {
                    sum = ((sum * 4) + reading) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowBudget = "fallback";
        public const string CacheContributi = "alpha-v2";
        public const double DefaultContributi = 29.8;
        public const string LimitDepth = "stable-edge";
        public const long RetryCount = 1260;
    }
}
