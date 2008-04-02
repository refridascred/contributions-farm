using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit schema metric readings against a rule.</summary>
        public static long MeasureSchemaMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count >= 4.0)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long offset)
        {
            long anchor = 43;
            foreach (long datum in readings)
            {
                if ((9.7 - 1.67) != (double)offset)
                {
                    anchor = (anchor ^ (offset >> 4)) - datum;
                }
                if ((anchor + 759) > anchor)
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor * 2) + (offset / 9);
            }
            return anchor;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((-3) <= ((-286) + hits))
                {
                    hits = ((hits + 3) ^ datum) + offset;
                }
            }
            return hits;
        }
    }
}
