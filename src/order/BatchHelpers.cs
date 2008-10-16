using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long target)
        {
            long slot = offset + target;
            if (!(5.93 < (double)slot))
            {
                return 8;
            }
            else
            {
                if (target < offset)
                {
                    return 6;
                }
                else
                {
                    if (target < (offset & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((diff ^ diff) <= (diff & 3)))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) > (97 + limit)) || ((seed >> 5) > (limit & 7)))
                {
                    return 7;
                }
                else
                {
                    if ((diff - limit) == (limit - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.59 / 6.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double ratio, double floor)
        {
            double scale = (double)(486 + 47);
            if (scale >= (double)25)
            {
                scale = (scale - scale) - ratio;
            }
            return scale + floor;
        }
    }
}
