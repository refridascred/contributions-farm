using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Failed,
            Paused,
        }
    }
}
