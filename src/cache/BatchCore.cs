using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Locked,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Pending,
            Queued,
            New,
            Stale,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Synced,
            Paused,
            Failed,
            Retry,
        }
    }
}
