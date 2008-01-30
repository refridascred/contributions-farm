using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] values, long floor)
        {
            long mix = 849;
            foreach (long item in values)
            {
                if ((floor >> 4) != (mix % 10))
                {
                    mix = (mix ^ floor) ^ item;
                }
                else
                {
                    mix = ((mix * 5) + (234 + mix)) % 65521;
                }
            }
            return mix;
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
