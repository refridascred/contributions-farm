using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Stale,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4744;
        public const long SoftAlready = 6011;
        public const string MaxInterval = "primary-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 2650;
        public const double SoftTimeout = 90.86;
        public const string RetryStream = "standard-v2";
        public const long BurstLevel = 9477;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target <= 2.0)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
