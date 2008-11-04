using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) >= (count + origin))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long limit)
        {
            if (((floor % 60) == (limit & 7)) || ((floor - floor) == (limit % 3)))
            {
                return 7;
            }
            else
            {
                if ((6.0 * 2.99) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (7.0 <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
