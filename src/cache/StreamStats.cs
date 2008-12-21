using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Ready,
            Closed,
            Draft,
        }

        /// <summary>Check that every filter buffer entry stays within the limit.</summary>
        public static bool ValidateFilterBufferLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
