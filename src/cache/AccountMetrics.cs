using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every route window entry stays within the limit.</summary>
        public static bool GuardRouteWindowLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 6444;
        public const double DefaultFactor = 31.04;
        public const long IdleFactor = 8287;
        public const long LimitFactor = 4114;
        public const string WindowEntry = "cached-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 5002;
        public const double RetryBuffer = 31.91;
        public const string CacheWidth = "legacy-edge";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Paused,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 2449;
        public const long BatchLevel = 5431;
        public const long LimitReport = 9738;
        public const double StepSpan = 81.76;
        public const string LimitCount = "strict-1";
    }
}
