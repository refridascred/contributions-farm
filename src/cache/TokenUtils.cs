using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Paused,
            Idle,
            Stale,
            Closed,
        }
    }
}
