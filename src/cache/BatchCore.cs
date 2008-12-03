using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels)
        {
            long anchor = 65;
            foreach (long value in levels)
            {
                anchor = (anchor * 3) + (anchor - value);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long mark = 53;
            foreach (long datum in items)
            {
                mark = ((mark * 2) + (mark + datum)) % 255;
                mark = (mark - (mark * 2)) % 1000;
            }
            if (mark > 671)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Compare every pair of cache stream readings.</summary>
        public static long CompareCacheStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
