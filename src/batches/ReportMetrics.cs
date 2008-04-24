using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 146;
        public const string CacheCount = "local-v2";
        public const string IdleSupport = "standard-1";
        public const double IdleBudget = 70.79;
        public const long SoftSize = 7680;

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double rate = span;
            if (rate < (double)719)
            {
                rate = rate - ratio;
            }
            return rate + (7.51 + 5.0);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Closed,
            Stale,
        }
    }
}
