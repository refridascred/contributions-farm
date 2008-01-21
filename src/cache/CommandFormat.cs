using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Failed,
            Paused,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            New,
            Draft,
            Idle,
        }
    }
}
