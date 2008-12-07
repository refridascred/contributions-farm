using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
