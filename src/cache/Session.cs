using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "open-1";
        public const long RetryWidth = 6177;
        public const double LimitStats = 94.5;
        public const double IdleStats = 95.34;
        public const long BaseStats = 4969;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Failed,
            Idle,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRatio = 16.1;
        public const double MinBudget = 26.11;
        public const double CacheRecord = 96.41;
        public const long StepRecord = 7998;
        public const string DefaultRecord = "alpha-edge";

        /// <summary>Validate account cache readings against a bound.</summary>
        public static bool VerifyAccountCacheRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
