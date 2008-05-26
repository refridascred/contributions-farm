using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 2687;
        public const double BatchBudget = 30.32;
        public const string MinBatches = "legacy-1";
        public const long DefaultBatches = 3798;
        public const long BaseBudget = 8101;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Idle,
            Dropped,
            Retry,
        }
    }
}
