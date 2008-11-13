using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Done,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Retry,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Stale,
            Done,
            Locked,
        }
    }
}
