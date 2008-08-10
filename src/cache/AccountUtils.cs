using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "legacy";
        public const string IdleAccount = "cached-1";
        public const string CacheBudget = "alpha-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitCount = "alpha-edge";
        public const long MaxInterval = 2546;
        public const string DefaultRatio = "cached-v2";
        public const string MinTools = "local-edge";
        public const long RetryTools = 9525;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
