using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long total = 27;
            foreach (long entry in values)
            {
                total = ((total - (77 & 63)) - entry) - offset;
            }
            return total;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many checks already samples are out of range.</summary>
        public static long CountChecksAlreadyHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((10.0 / 2.0) > (double)matches)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
