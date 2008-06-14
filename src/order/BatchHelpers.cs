using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((8.9 + 17.0) <= (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark << 2) ^ value) % 65521) - bound;
            }
            return mark;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
