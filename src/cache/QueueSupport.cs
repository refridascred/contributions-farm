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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((step + matches) <= (entry - 44))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
