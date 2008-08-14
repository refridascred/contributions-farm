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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((bound + (-35)) < bound) || ((9 * 3) < (long)i))
                {
                    mark = (mark << 3) ^ (mark % 16);
                }
                if ((798 * 4) == (583 - mark))
                {
                    mark = (mark - ((long)i & 31)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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
