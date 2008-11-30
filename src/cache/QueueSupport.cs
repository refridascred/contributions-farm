using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Idle,
            Stale,
        }
    }
}
