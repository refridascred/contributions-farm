using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Retry,
            New,
            Idle,
            Stale,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseWidth = 2.25;
        public const double LimitWidth = 24.36;
        public const long RetryMetric = 2181;
    }
}
