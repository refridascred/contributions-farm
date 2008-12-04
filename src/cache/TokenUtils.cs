using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1789;
        public const double IdleMetrics = 84.18;
        public const long CacheLevel = 9533;
        public const long BurstMetrics = 3362;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Pending,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
