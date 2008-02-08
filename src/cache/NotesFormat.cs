using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Stale,
            Draft,
        }
    }
}
