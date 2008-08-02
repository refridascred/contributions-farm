using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Ready,
            Draft,
            Synced,
            New,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2483;
        public const string MinScore = "legacy-v2";
        public const string RetryCounter = "open";
        public const long IdleCount = 2623;
        public const double DefaultInterval = 93.69;
    }
}
