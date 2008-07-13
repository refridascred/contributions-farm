using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Idle,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 1185;
        public const long SoftFactor = 7882;
        public const long SoftRatio = 1930;
    }
}
