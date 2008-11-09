using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 51.13;
        public const long DefaultCount = 3385;
        public const long MaxTimeout = 8508;
        public const double LimitWindow = 44.08;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.83 - 9.94) == (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item << 1) != (seen + step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
