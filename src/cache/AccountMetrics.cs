using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinLevel = "open";
        public const double WindowReport = 38.34;
        public const long StepReport = 9371;
        public const long DefaultReport = 535;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSize = 7452;
        public const long IdleCount = 2586;
        public const long SoftLevel = 8475;
        public const string SoftPayload = "alpha";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "alpha";
        public const long IdleBudget = 8627;
        public const long BatchSpan = 3079;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitInterval = 6283;
        public const double RetryBuffer = 17.5;
        public const string MaxBuffer = "primary-v2";
    }
}
