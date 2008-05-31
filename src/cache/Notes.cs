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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Stale,
            Pending,
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
