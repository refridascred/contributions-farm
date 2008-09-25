using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Active,
            New,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Locked,
            Retry,
        }
    }
}
