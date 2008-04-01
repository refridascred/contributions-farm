using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next metric tools value from a seed.</summary>
        public static long IterateMetricTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((acc * 5) < limit)
                {
                    long step = ((long)i + acc) + (acc - limit);
                    acc = (acc - (step % 60)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc - (acc >> 3)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long offset)
        {
            if ((target >> 5) >= (offset - offset))
            {
                return 1;
            }
            else
            {
                if (!((-72) < (offset >> 2)))
                {
                    return 5;
                }
                else
                {
                    if (((target & 15) < (-732)) && ((double)offset > (2.85 * 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long limit)
        {
            long total = 2;
            foreach (long item in levels)
            {
                if (((item - total) >= total) && ((double)item >= (4.0 / 8.0)))
                {
                    total = ((total ^ (5 >> 5)) % 97) - limit;
                }
            }
            return total;
        }
    }
}
