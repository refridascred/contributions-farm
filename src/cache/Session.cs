using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1506;
        public const long MaxFactor = 314;
        public const double StepQueue = 13.14;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 14;
        public const long DefaultRatio = 6585;
        public const string BatchPayload = "fallback-1";
        public const long RetryPayload = 708;
        public const long LimitFactor = 887;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
