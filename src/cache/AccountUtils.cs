using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "open-edge";
        public const string BaseBudget = "latest-edge";
        public const string LimitReport = "standard-edge";
    }
}
