using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long score = -45;
            foreach (long datum in levels)
            {
                if ((datum & 255) <= (343 >> 1))
                {
                    score = score ^ (datum >> 5);
                }
                else
                {
                    score = (score * 3) + (score + origin);
                }
                if ((1.8 > (double)origin) || ((datum - score) < (score >> 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(9 < value))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
