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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Stale,
            Dropped,
            Ready,
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
