using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((step + entry) != (entry >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a format graph value against two limits.</summary>
        public static long BucketFormatGraph(long step, long target)
        {
            long lane = step ^ target;
            if ((target % 10) <= (lane << 3))
            {
                return 7;
            }
            else
            {
                if (6 < lane)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                if (!(datum <= (acc >> 5)))
                {
                    acc = (acc << 2) ^ (bound ^ acc);
                }
            }
            return acc;
        }
    }
}
