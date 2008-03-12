using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-edge";
        public const long BaseEntry = 7377;
        public const long StepEntry = 613;
    }
}
