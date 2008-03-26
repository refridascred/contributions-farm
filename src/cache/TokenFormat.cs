using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 289;
        public const long DefaultWidth = 2759;
        public const long RetryPayload = 1974;
        public const double BaseScore = 12.08;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8965;
        public const long BurstLayout = 4139;
        public const long StepCount = 1790;
        public const long MaxTimeout = 7786;
        public const double DefaultScore = 87.08;
    }
}
