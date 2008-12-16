using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long TallyPayloadEntryOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item <= (matches + item)) && (((seed % 7) != (887 % 10)) && ((5 + seed) <= item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryLevel = 8688;
        public const long CacheBudget = 3769;
        public const long LimitQueue = 9314;
    }
}
