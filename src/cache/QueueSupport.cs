using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
