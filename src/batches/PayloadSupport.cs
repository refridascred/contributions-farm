using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Closed,
            Pending,
            New,
            Queued,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Retry,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Idle,
            Done,
            Stale,
        }
    }
}
