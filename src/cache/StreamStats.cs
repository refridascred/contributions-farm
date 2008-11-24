using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two stream counter measurements.</summary>
        public static double BlendStreamCounter(double ratio, double offset)
        {
            double rate = (double)(52 ^ 0);
            if (rate < (rate / 5.0))
            {
                rate = (rate - (ratio * 10.0)) + offset;
            }
            return rate - (ratio + ratio);
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
