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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count < 9.1)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
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
