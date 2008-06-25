using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)331 < (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats payload sample.</summary>
        public static long LookupStatsPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "local-1";
        public const double MaxContext = 11.13;
        public const long CacheLevel = 4047;
        public const string WindowTimeout = "staging";
    }
}
