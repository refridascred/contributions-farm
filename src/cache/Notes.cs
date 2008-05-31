using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool GuardTokenChannelRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long target, long offset)
        {
            long gap = target + offset;
            if (((target + target) > (gap / 4)) || ((double)gap < (double)849))
            {
                return 0;
            }
            else
            {
                if ((gap & 7) != (offset - target))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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
