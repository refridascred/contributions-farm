using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metric route samples are out of range.</summary>
        public static long AuditMetricRouteOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((double)value != (19.0 * 1.14)) || (((value % 60) <= hits) && ((0.44 / 9.0) > (double)origin)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the notes entry entries that pass the check.</summary>
        public static long MeasureNotesEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length > 706) || ((cell % 10) > (hits + (long)items.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long origin, long limit)
        {
            long step = origin - limit;
            if (origin > (limit / 6))
            {
                return 1;
            }
            else
            {
                if ((step - 117) <= (56 << 1))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit >= (4.21 + 6.0)) || (step > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
