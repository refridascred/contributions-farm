using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
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
