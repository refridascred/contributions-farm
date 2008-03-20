using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Synced,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Stale,
            Pending,
            Locked,
        }
    }
}
