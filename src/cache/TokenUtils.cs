using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "stable-edge";
        public const long IdleEditor = 3737;
        public const long BurstEditor = 3744;
        public const long MaxWidth = 8424;
        public const long BatchBudget = 1838;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)hits >= (double)cell) && (hits < (306 + 3)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
