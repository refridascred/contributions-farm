using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Draft,
            Paused,
            Dropped,
        }
    }
}
