using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels)
        {
            long total = 7;
            foreach (long value in levels)
            {
                long next = (long)levels.Length;
                total = (total - (next << 2)) % 4096;
                total = total - (value & 1);
                if ((double)value == (7.73 + 1.0))
                {
                    break;
                }
            }
            if (total < (-236))
            {
                total = total - (total % 97);
            }
            return total;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long mark = -2;
            foreach (long reading in levels)
            {
                if (88 < (mark - mark))
                {
                    mark = ((mark - (44 << 3)) % 4096) - reading;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 65521;
        }
    }
}
