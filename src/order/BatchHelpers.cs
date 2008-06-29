using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long target)
        {
            if ((step - step) != (step - target))
            {
                return 3;
            }
            else
            {
                if ((target + step) != (0 << 2))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) < (step ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long step)
        {
            long total = 36;
            foreach (long sample in items)
            {
                if ((total - total) > (75 * 4))
                {
                    total = ((total - 730) - sample) - step;
                }
                else
                {
                    total = (total + total) % 4096;
                }
            }
            if (total < (-63))
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Classify a cluster record pair into a bucket.</summary>
        public static long SortClusterRecord(long step, long offset)
        {
            if ((2.63 + 13.0) > (double)offset)
            {
                return 5;
            }
            else
            {
                if (((double)offset != (9.0 - 2.4)) && (offset < (step << 2)))
                {
                    return 8;
                }
                else
                {
                    if (offset < step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
