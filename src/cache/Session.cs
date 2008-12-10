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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long slot = seed ^ bound;
            if (slot > (seed + slot))
            {
                return 5;
            }
            else
            {
                if ((seed >> 2) <= (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if ((slot - bound) >= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot / 7) <= (533 + bound))
                        {
                            return 7;
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
}
