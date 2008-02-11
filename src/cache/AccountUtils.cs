using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepFactor = 3108;
        public const double LimitMetrics = 55.6;
        public const long StepMetrics = 6109;
        public const long IdleMetrics = 5904;

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

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 9138;
        public const double BaseGraph = 4.81;
        public const long IdleRatio = 6190;
        public const long DefaultSpan = 4285;
    }
}
