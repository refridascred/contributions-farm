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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
