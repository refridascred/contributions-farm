using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long seed)
        {
            long slot = offset + seed;
            if ((seed ^ offset) >= (offset >> 5))
            {
                return 7;
            }
            else
            {
                if ((slot / 9) < offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the queue route series from a seed.</summary>
        public static long IterateQueueRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the order counter entries that pass the check.</summary>
        public static long MeasureOrderCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally / 6) == (9 * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }
    }
}
