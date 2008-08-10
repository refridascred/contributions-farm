using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 9217;
        public const long HardTimeout = 7037;
        public const string CacheSize = "cached";
        public const long IdleBudget = 1971;

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
