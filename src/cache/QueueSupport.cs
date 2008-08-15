using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long offset)
        {
            long mark = -65;
            foreach (long cell in series)
            {
                mark = (((mark * 2) + (mark % 12)) ^ cell) - offset;
            }
            return mark;
        }
    }
}
