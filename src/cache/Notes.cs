using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Synced,
            Retry,
            Active,
            Done,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool ValidateFarmProfileLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the report command entries that pass the check.</summary>
        public static long MeasureReportCommandMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((floor * 4) == (cell >> 3)) && (seen <= (floor ^ cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long AuditChannelProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 15) < (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
