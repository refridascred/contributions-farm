using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits ^ hits) > (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long IterateBatchesWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
