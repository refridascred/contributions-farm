using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 4579;
        public const long BurstContributi = 9052;
        public const long BatchBudget = 5951;
        public const long LimitContributi = 1869;
        public const string RetryContributi = "fallback-v2";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseBudget = 2629;
        public const long BurstTools = 7716;
        public const long BaseCount = 8601;
        public const double DefaultTools = 44.01;
        public const long BatchTools = 6688;
    }
}
