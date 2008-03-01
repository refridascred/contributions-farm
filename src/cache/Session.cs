using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long origin)
        {
            long diff = offset + origin;
            if ((origin << 3) > (offset % 10))
            {
                return 6;
            }
            else
            {
                if ((1.69 / 8.0) <= (double)diff)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((14.0 / 6.0) >= (double)matches)
                {
                    matches = ((matches + 3) - item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long AuditCommitsClusterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count > (count - count)) || (15.0 < (double)entry))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
