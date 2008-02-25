using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Synced,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) != (datum * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples, long seed)
        {
            long result = 48;
            foreach (long item in samples)
            {
                if (((long)samples.Length + result) > (result - 549))
                {
                    break;
                }
                if (!((20.0 - 1.0) != (double)result))
                {
                    result = (((result * 2) + (result * 3)) + item) + seed;
                }
            }
            return result;
        }
    }
}
