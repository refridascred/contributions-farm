using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 7391;
        public const string BurstSize = "fallback-v2";
        public const long MinWidth = 7085;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Retry,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool VerifyAccountReportRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
