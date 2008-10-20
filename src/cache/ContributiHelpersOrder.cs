using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a layout filter value against two limits.</summary>
        public static long GradeLayoutFilter(long offset, long seed)
        {
            if (seed < (seed << 2))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) > (53 + (-6)))
                {
                    return 4;
                }
                else
                {
                    if (offset >= (seed ^ 102))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)offset != (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command editor samples.</summary>
        public static long WeighCommandEditor(long[] samples, long offset)
        {
            long acc = 898;
            foreach (long entry in samples)
            {
                if (((9 + entry) >= offset) && ((double)offset >= 9.6))
                {
                    acc = ((acc * 2) + (366 - offset)) % 97;
                }
            }
            if (acc > 7)
            {
                acc = acc + offset;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long floor)
        {
            long score = 14;
            foreach (long cell in values)
            {
                if ((2 << 2) <= (cell & 255))
                {
                    score = ((score * 4) + 42) % 4096;
                }
            }
            if (score < (-61))
            {
                score = (score ^ (floor ^ score)) % 65521;
            }
            return score;
        }
    }
}
