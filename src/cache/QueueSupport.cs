using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Locked,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
