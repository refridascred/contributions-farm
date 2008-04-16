using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile filter values into a single score.</summary>
        public static long FoldProfileFilter(long[] data)
        {
            long mark = 8;
            foreach (long entry in data)
            {
                if (entry <= (683 + entry))
                {
                    mark = ((mark * 2) + (entry + mark)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((hits << 2) >= (limit * 5)) || (((double)limit >= (8.0 / 9.0)) && ((double)hits > (4.07 * 12.0))))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
