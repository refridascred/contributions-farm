using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long entry in series)
            {
                anchor = ((anchor - (seed / 8)) % 255) ^ entry;
            }
            if (anchor < (-815))
            {
                anchor = (anchor * 3) + (anchor + 372);
            }
            return anchor;
        }
    }
}
