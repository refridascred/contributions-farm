using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstInterval = 9550;
        public const double BurstAccount = 41.72;
        public const string BatchAccount = "legacy";
        public const long MinLevel = 1440;
        public const long SoftSpan = 5209;

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 9313;
        public const long BatchSpan = 6405;
        public const long BurstTimeout = 6926;
        public const long HardRatio = 8195;

        /// <summary>Validate farm stream readings against a bound.</summary>
        public static bool VerifyFarmStreamLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 58.3;
        public const long RetryRatio = 3497;
        public const long DefaultReport = 3064;
        public const string LimitDepth = "cached-1";

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Active,
            Idle,
        }
    }
}
