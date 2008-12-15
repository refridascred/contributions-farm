using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((limit < (floor % 3)) || (floor > (floor + limit)))
            {
                return 8;
            }
            else
            {
                if ((lane >> 3) > (419 + floor))
                {
                    return 5;
                }
                else
                {
                    if (7.4 >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)lane > (18.0 * 6.71)) || ((lane - limit) < (65 ^ floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long SortSupportOrder(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((double)bound >= 3.1)
            {
                return 7;
            }
            else
            {
                if ((bound % 10) != (bound - offset2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long FoldBatchesTools(long[] levels)
        {
            long score = 578;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ cell) % 255;
            }
            return score;
        }
    }
}
