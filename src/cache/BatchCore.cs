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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((1 % 10) >= value)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings)
        {
            long total = 43;
            foreach (long reading in readings)
            {
                if (total > (reading + reading))
                {
                    total = (total + total) % 101;
                }
            }
            return total % 65521;
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
