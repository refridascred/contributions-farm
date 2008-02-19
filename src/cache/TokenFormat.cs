using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Failed,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 23.42;
        public const string SoftQueue = "latest-1";
        public const long StepQueue = 9384;
        public const long MinQueue = 7901;
        public const string WindowQueue = "fallback-edge";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Paused,
            Done,
        }
    }
}
