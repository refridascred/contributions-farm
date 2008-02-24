using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
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
