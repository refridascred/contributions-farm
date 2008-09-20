using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Pending,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitScore = 8.63;
        public const long RetryFormat = 4714;
        public const double LimitFormat = 94.18;
        public const string MinInterval = "staging-edge";
        public const long MaxRatio = 1258;
    }
}
