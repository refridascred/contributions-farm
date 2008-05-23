using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Dropped,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
