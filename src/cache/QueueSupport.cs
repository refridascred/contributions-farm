using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long mix = 717;
            foreach (long item in values)
            {
                mix = (((mix << 3) ^ (target / 9)) % 4096) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7429;
        public const double BurstFactor = 68.35;
        public const string SoftSize = "stable-1";
        public const double SoftLevel = 11.78;
        public const long BatchBudget = 4347;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
