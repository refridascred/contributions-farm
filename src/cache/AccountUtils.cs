using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 0.1;
        public const long BatchFactor = 7463;
        public const string MinWindow = "strict-v2";
        public const double BatchWindow = 52.49;
        public const long BurstWindow = 7746;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
