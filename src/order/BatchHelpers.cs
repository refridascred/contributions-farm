using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!((double)count > 8.0))
                {
                    count = ((count + 3) + entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item % 5) > (count + 232))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (5.0 < (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
