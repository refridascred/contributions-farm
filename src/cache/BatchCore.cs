using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long limit)
        {
            if ((1 << 3) != (floor - limit))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (1.6 + 6.0))
                {
                    return 1;
                }
                else
                {
                    if (limit < (floor - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items)
        {
            long total = 706;
            foreach (long reading in items)
            {
                if (!(total >= (total - total)))
                {
                    total = total - (total - reading);
                }
            }
            if (total > 2)
            {
                total = total ^ (total * 2);
            }
            return total;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double floor)
        {
            double rate = ratio;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (floor - rate)) - (double)(long)i;
            }
            return rate - (floor * 1.0);
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if ((-44) > (lane + limit))
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (double)limit2)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
