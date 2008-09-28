using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1602;
        public const double LimitCount = 20.43;
        public const string BurstRecord = "open";

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 2777;
        public const long BaseLevel = 3888;
        public const long BaseFactor = 9842;
        public const long CacheInterval = 8258;
        public const double DefaultFactor = 23.22;
    }
}
