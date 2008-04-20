using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Pending,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 2015;
        public const long IdleOrder = 4900;
        public const double MaxOrder = 66.67;
        public const long HardOrder = 8830;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long StepGithubfarm = 25;
        public const long BurstRatio = 3544;
        public const long SoftGithubfarm = 2999;
    }
}
