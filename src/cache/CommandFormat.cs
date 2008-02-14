using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Classify a counter route pair into a bucket.</summary>
        public static long BucketCounterRoute(long bound, long seed)
        {
            if ((double)712 != (double)seed)
            {
                return 2;
            }
            else
            {
                if (16.0 > (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((5.0 + 8.96) == (double)origin))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long TallySupportToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) <= (reading + matches)) || (((-2) % 7) <= (matches & 31)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
