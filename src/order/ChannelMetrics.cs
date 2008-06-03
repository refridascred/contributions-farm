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

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
