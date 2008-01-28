using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5953;
        public const long BurstCommand = 1289;
        public const long RetryBudget = 9883;
        public const long RetryCommand = 2302;
        public const double MaxTimeout = 72.83;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
