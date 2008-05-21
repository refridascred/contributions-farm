using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSize = 82.87;
        public const string IdleSupport = "latest-1";
        public const string RetryRatio = "primary-1";
        public const long StepSupport = 491;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftCount = 19.43;
        public const long MaxChecks = 4667;
        public const long BaseChecks = 8020;
        public const string RetryChecks = "stable-edge";
        public const long RetryScore = 5959;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
