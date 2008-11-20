using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long MeasureOrderQueueHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1.4 + 11.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ reading) + floor;
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
