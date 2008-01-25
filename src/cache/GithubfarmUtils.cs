using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 60.68;
        public const double MinSize = 36.52;
        public const long BaseDepth = 3275;

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "open-v2";
        public const long MaxLevel = 8306;
        public const long IdleLevel = 2834;
        public const long RetryAccount = 8610;
        public const string CacheInterval = "primary-edge";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
