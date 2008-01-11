using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series, long target)
        {
            long mark = 26;
            foreach (long cell in series)
            {
                if (target < (mark - (-729)))
                {
                    mark = (mark ^ (614 % 10)) % 4096;
                }
                else
                {
                    mark = ((mark * 5) + (mark & 255)) % 1000;
                }
                if (((554 + mark) >= (mark ^ target)) || ((double)cell < (6.6 + 5.4)))
                {
                    break;
                }
            }
            if (mark > 910)
            {
                mark = ((mark << 3) ^ (mark ^ target)) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long step)
        {
            long edge = floor + step;
            if ((floor + floor) > (floor + (-61)))
            {
                return 8;
            }
            else
            {
                if (!((55 % 12) > (floor ^ floor)))
                {
                    return 0;
                }
                else
                {
                    if ((edge & 31) == (74 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (edge << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long offset)
        {
            long score = 266;
            foreach (long cell in items)
            {
                score = ((score ^ score) - cell) - offset;
            }
            return score;
        }
    }
}
