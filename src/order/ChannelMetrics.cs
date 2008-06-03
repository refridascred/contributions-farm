using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long mark = 12;
            foreach (long value in values)
            {
                mark = mark + (limit % 97);
                if ((limit ^ value) <= (value - limit))
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = (mark * 5) + (limit ^ limit);
            }
            return mark % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long total = 6;
            foreach (long entry in values)
            {
                if ((153 + 0) > (total << 1))
                {
                    total = (total + (entry << 2)) % 65521;
                }
                else
                {
                    total = total + (8 >> 1);
                }
            }
            if (total > 557)
            {
                total = (total * 4) + ((long)values.Length % 97);
            }
            return total;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
