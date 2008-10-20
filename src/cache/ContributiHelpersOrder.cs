using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a stream counter pair into a bucket.</summary>
        public static long SortStreamCounter(long floor, long limit)
        {
            long slot = floor + limit;
            if (!(slot < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if (!(7.5 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((slot + floor) != (limit / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
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
