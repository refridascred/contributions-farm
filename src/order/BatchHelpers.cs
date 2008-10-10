using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long offset)
        {
            if (((double)offset < (8.0 - 2.3)) || ((target - offset) <= ((-8) + offset)))
            {
                return 4;
            }
            else
            {
                if (target < 50)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many layout entry samples are out of range.</summary>
        public static long MeasureLayoutEntryGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value % 10) < value)
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
