using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long mark = 456;
            foreach (long value in samples)
            {
                mark = (((mark * 4) + (mark / 8)) + value) - seed;
            }
            return mark;
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
