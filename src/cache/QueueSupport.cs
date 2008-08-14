using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Active,
            Paused,
            Pending,
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
