using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Draft,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 5424;
        public const long StepTools = 6337;
        public const double LimitTools = 57.81;
    }
}
