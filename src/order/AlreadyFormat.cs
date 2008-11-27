using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1934;
        public const long StepInterval = 1582;
        public const long BaseDepth = 9870;
        public const long DefaultCount = 8124;

        /// <summary>Find the first graph batch entry that matches the target.</summary>
        public static long FindGraphBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((offset > (sample + offset)) && ((569 + sample) > hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3571;
        public const long MinRatio = 377;
        public const double BaseEditor = 87.46;
        public const long RetryFactor = 4965;
    }
}
