using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
