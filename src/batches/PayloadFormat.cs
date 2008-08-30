using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two cluster channel measurements.</summary>
        public static double ScaleClusterChannel(double ratio, double floor)
        {
            double scale = (double)(289 ^ 93);
            if (scale > scale)
            {
                scale = (scale + (double)226) - ratio;
            }
            else
            {
                scale = scale + (floor * 6.88);
            }
            return scale + scale;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long AuditRouteCacheGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((hits * 5) > bound) || ((double)item >= (0.6 + 4.44))) || (((2.46 * 8.33) >= (double)hits) || ((item + item) >= (bound - bound))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + 9) > (reading % 7))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
