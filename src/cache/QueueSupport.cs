using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Dropped,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
