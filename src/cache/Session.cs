using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.9 * 6.29) > (double)count)
                {
                    count = ((count + 2) + entry) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long origin)
        {
            if ((3.9 * 4.1) < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((68 + origin) <= (offset + (-5)))
                {
                    return 5;
                }
                else
                {
                    if (((5.52 + 2.6) >= (double)origin) && (offset <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Pending,
            Stale,
            Closed,
            New,
        }
    }
}
