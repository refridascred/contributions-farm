using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - 3) < (matches * 5))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + hits) < (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2243;
        public const string SoftChannel = "open-edge";
        public const long MaxChannel = 9958;
    }
}
