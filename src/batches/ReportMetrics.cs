using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the batch profile entries that pass the check.</summary>
        public static long CountBatchProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item ^ hits) == (hits + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
