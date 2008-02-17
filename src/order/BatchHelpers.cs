using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] items, long origin)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                acc = acc ^ (cell * 2);
                acc = (acc + (cell * 2)) % 1000;
                if (!(origin <= (origin - 21)))
                {
                    acc = (acc << 2) ^ (origin - origin);
                }
            }
            return acc;
        }
    }
}
