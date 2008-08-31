using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Synced,
        }
    }
}
