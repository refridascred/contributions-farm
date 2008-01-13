using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Queued,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if ((618 >> 5) <= (item * 2))
                {
                    result = (result << 3) ^ (item % 64);
                }
                if ((43 + item) < (671 + item))
                {
                    result = (result ^ (item ^ 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Locked,
            Stale,
            Dropped,
        }
    }
}
