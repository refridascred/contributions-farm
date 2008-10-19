using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetrySpan = "stable";
        public const long MinTimeout = 8287;
        public const double BaseFilter = 78.28;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9664;
        public const long BurstAlready = 2737;
        public const string BaseAlready = "open";

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Stale,
            Draft,
        }
    }
}
