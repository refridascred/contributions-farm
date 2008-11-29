using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
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
