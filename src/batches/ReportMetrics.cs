using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + value) < (hits - hits))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
