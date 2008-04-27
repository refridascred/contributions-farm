using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((cur * 3) < (limit2 + cur))
            {
                return 5;
            }
            else
            {
                if (limit >= (limit2 >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit < (limit2 - 0)) || ((limit * 3) <= cur))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (double)(-41)) + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Grade a queue cluster value against two limits.</summary>
        public static long ClassifyQueueCluster(long seed, long target)
        {
            if ((target > 6) && (60 >= (target - seed)))
            {
                return 1;
            }
            else
            {
                if (!((target << 1) <= seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
