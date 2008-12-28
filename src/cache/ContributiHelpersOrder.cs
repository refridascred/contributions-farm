using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Closed,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
