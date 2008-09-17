using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Draft,
            Closed,
            Synced,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 736;
        public const double RetryDepth = 35.16;
        public const string MinBatch = "strict-1";
    }
}
