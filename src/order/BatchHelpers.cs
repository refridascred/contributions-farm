using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "latest-edge";
        public const long HardInterval = 966;
        public const long RetryBudget = 6677;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long mark = -2;
            foreach (long value in data)
            {
                if ((double)offset != (3.5 - 9.24))
                {
                    mark = (mark + (offset % 5)) ^ value;
                    mark = (mark ^ (offset * 5)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (offset << 3)) % 1000;
                }
                if (offset <= (offset ^ offset))
                {
                    mark = ((mark * 4) + mark) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark * 3)) % 101;
                }
            }
            return mark;
        }
    }
}
