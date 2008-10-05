using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batch layout entries that pass the check.</summary>
        public static long CountBatchLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((-3) > (7 + seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Count the already metric entries that pass the check.</summary>
        public static long MeasureAlreadyMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((datum ^ count) == (count + datum)) || (count > (datum + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record support samples are out of range.</summary>
        public static long MeasureRecordSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((7.24 * 19.0) == (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
