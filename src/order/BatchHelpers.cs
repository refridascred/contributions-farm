using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4354;
        public const long CacheEntry = 720;
        public const long MaxLevel = 3870;
        public const long SoftInterval = 195;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of entry filter readings.</summary>
        public static long CompareEntryFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
