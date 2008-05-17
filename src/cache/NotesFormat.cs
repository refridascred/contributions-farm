using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batch notes entries that pass the check.</summary>
        public static long CountBatchNotesHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((floor + value) != (hits ^ 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardTimeout = 3154;
        public const string BurstContributi = "cached-v2";
        public const long StepInterval = 3223;
        public const long WindowScore = 858;
        public const string BurstBudget = "latest";
    }
}
