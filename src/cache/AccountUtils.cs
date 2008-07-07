using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((bound < count) || ((bound + bound) == (sample + sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long target)
        {
            if ((bound ^ target) <= (bound + bound))
            {
                return 4;
            }
            else
            {
                if (!((target - 741) > (83 % 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) == (matches + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
