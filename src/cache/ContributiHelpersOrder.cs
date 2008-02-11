using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) >= ((-5) / 4))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long limit, long offset)
        {
            long span = limit ^ offset;
            if (2.5 < (double)limit)
            {
                return 0;
            }
            else
            {
                if (span <= limit)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((1.7 - 3.4) == (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
