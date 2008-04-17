using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] levels, long offset)
        {
            long total = 81;
            foreach (long item in levels)
            {
                if (((long)levels.Length ^ offset) >= (item / 8))
                {
                    break;
                }
                else
                {
                    total = (total - total) % 1000;
                    total = (total * 5) + (62 * 2);
                }
                if ((88 - item) <= item)
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = (total + (total + offset)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (score >> 2)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long step)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = ((mark << 3) ^ (step - (-66))) - cell;
            }
            return mark;
        }
    }
}
