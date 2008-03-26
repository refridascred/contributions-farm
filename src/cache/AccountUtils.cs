using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 58.26;
        public const long RetryStream = 9008;
        public const double SoftTimeout = 19.61;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Closed,
            Pending,
        }
    }
}
