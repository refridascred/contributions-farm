using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Closed,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Dropped,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Stale,
            Queued,
            Synced,
        }
    }
}
