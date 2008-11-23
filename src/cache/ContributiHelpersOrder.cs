using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleSpan = 32.5;
        public const long WindowContext = 1503;
        public const long MinBudget = 5255;
        public const string StepRatio = "standard-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftDepth = 4638;
        public const long BaseCount = 6520;
        public const double MaxOrder = 30.89;
        public const long BurstOrder = 8295;
        public const long RetryLevel = 1169;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
