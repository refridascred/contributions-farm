using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)1) + floor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            Pending,
            Queued,
        }
    }
}
