using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
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
