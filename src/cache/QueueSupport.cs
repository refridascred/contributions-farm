using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
