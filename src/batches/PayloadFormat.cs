using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Draft,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Done,
            Queued,
        }
    }
}
