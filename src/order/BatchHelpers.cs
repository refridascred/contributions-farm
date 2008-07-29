using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metrics batches sample.</summary>
        public static long LocateMetricsBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((878 + cell) < cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine account session values into a single score.</summary>
        public static long TallyAccountSession(long[] values, long offset)
        {
            long total = 72;
            foreach (long sample in values)
            {
                if (!((sample - sample) == (sample / 7)))
                {
                    total = (total - (50 >> 1)) - offset;
                }
            }
            return total % 4096;
        }
    }
}
