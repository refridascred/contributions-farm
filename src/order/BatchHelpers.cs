using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            New,
            Draft,
        }
    }
}
