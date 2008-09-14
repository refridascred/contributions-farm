using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Ready,
            Paused,
            New,
            Queued,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 19.37;
        public const long WindowScore = 6612;
        public const string BurstMetric = "strict-edge";
        public const long WindowWidth = 5142;
        public const string RetryRatio = "local-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9403;
        public const long BaseChecks = 7967;
        public const long MaxSpan = 4220;
    }
}
