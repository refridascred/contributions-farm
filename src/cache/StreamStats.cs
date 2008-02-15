using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long total = 791;
            foreach (long item in readings)
            {
                if ((item % 60) != (total ^ (-8)))
                {
                    total = total - (913 % 64);
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 6312;
        public const long WindowTimeout = 907;
        public const long BatchPayload = 621;
        public const double BasePayload = 41.35;
        public const long RetryBudget = 3120;

        /// <summary>Compare every pair of githubfarm tools readings.</summary>
        public static long MatchGithubfarmToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
