using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(5 < (hits - sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((double)item == (5.0 / 5.0)) && (item <= (55 & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long target)
        {
            long prev = offset ^ target;
            if (!((586 << 3) <= (offset % 16)))
            {
                return 6;
            }
            else
            {
                if ((1.2 / 8.0) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((prev << 2) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
