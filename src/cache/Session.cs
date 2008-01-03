using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((long)values.Length << 1) < 659)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)limit > (6.5 * 4.61))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + item) <= (seed + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every order batch entry stays within the limit.</summary>
        public static bool ValidateOrderBatchRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
