using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4.7 * 2.0) < (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if (99 > floor)
            {
                return 4;
            }
            else
            {
                if ((floor * 5) <= (1 + target))
                {
                    return 6;
                }
                else
                {
                    if ((1.6 / 4.0) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (target / 2)) && ((floor * 5) > ((-12) & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            New,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Synced,
            Paused,
            Stale,
            Pending,
        }
    }
}
