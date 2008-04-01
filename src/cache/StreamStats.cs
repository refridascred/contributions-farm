using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheCount = "alpha-1";
        public const double IdleFactor = 60.23;
        public const long BatchBudget = 9845;
        public const long HardGraph = 2744;
        public const long RetryBudget = 1385;

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "legacy";
        public const string MinRatio = "fallback-v2";
        public const long SoftMetric = 2616;
        public const string IdleMetric = "strict-1";

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long TallyGraphToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (8.2 - 3.4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
