using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Stale,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheBudget = 19.06;
        public const string IdleStream = "legacy-v2";
        public const double MaxRatio = 35.34;
        public const string RetryStream = "primary-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 2527;
        public const long LimitSupport = 2361;
        public const long BaseSupport = 8574;
        public const long MinSupport = 7358;
    }
}
