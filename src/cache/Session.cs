using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Pending,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinInterval = 1187;
        public const double MaxBatches = 33.47;
        public const string IdleRatio = "legacy-1";
        public const long BatchSize = 7621;
        public const long MaxCount = 6275;
    }
}
