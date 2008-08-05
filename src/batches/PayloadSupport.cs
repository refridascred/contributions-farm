using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a support record counter forward.</summary>
        public static long IterateSupportRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long TallyRouteMetricMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (item + count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((double)seed < (20.0 / 9.0))
            {
                return 8;
            }
            else
            {
                if ((seed << 2) < (cur + seed))
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
