using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepScore = 82.6;
        public const long MaxInterval = 4613;
        public const string RetryToken = "latest-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "primary-edge";
        public const long CacheLayout = 5174;
        public const string BatchDepth = "cached";

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftRatio = "local";
        public const long IdleRatio = 6399;
        public const string StepSpan = "local-v2";
        public const double LimitCounter = 59.8;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstSize = 7455;
        public const long LimitInterval = 7092;
        public const long BaseMetrics = 1908;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
