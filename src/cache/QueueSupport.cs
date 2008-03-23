using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items, long offset)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                acc = (acc ^ (acc - entry)) % 97;
            }
            if (acc > (-83))
            {
                acc = ((acc * 3) + offset) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long bound)
        {
            if ((bound * 2) < 7)
            {
                return 4;
            }
            else
            {
                if (step >= bound)
                {
                    return 1;
                }
                else
                {
                    if (step >= (bound + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total ^ (total - origin)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    total = (total ^ (origin - origin)) + (long)i3;
                }
                if ((6.04 - 3.59) >= (double)total)
                {
                    total = (total + (long)i) % 255;
                    continue;
                }
                else
                {
                    total = total ^ (total ^ origin);
                    total = (total ^ total) % 1000;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
