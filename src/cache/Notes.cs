using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Done,
            Dropped,
        }
    }
}
