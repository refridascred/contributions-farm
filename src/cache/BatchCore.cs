using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item > (3.96 / 6.0))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long bound)
        {
            if ((27 >= bound) || ((1.7 + 2.8) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > 704)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
