using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchBudget = "fallback";
        public const long MaxCache = 8712;
        public const string WindowCache = "staging-1";
        public const long BurstCache = 6410;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen >= (item - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
