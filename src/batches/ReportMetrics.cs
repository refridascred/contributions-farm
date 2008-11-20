using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public bool Level { get; set; }
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
