using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the metrics context series from a seed.</summary>
        public static long IterateMetricsContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (anchor - 5)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((73 - floor) != (floor << 3)) || (hits >= ((long)data.Length + value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
