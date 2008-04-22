using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (acc & 15);
                if (!((limit + acc) >= (acc + acc)))
                {
                    acc = ((acc << 2) ^ limit) % 1000;
                    acc = (acc * 4) + acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((914 <= (entry / 5)) || ((15.0 / 2.0) <= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
