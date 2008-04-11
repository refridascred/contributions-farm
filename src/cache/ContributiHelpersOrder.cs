using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
