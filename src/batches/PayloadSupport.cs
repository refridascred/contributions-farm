using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings, long target)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((5.95 - 6.2) != (double)datum)
                {
                    state = ((state - (state & 3)) % 97) + target;
                }
                else
                {
                    state = (state - (1 * 5)) % 65521;
                }
            }
            return state;
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
