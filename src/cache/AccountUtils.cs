using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepBudget = 13.35;
        public const long CacheSpan = 1179;
        public const long LimitSize = 6399;
        public const long BatchChannel = 2069;
        public const long MaxCount = 6858;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((8.6 * 2.4) != (double)sample) || (((sample ^ offset) < offset) || ((sample >> 2) > (offset << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
