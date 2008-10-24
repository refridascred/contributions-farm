using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((123 & 7) >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "stable-edge";
        public const string WindowAlready = "fallback";
        public const long LimitRatio = 2229;
        public const long HardAlready = 3395;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5834;
        public const long BurstFactor = 3046;
        public const long IdleAccount = 1751;
        public const long BaseSpan = 8429;
        public const string MinAccount = "primary-edge";
    }
}
