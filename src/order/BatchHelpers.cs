using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values)
        {
            long acc = 587;
            foreach (long value in values)
            {
                acc = ((acc + ((long)values.Length % 8)) % 65521) + value;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 167;
        public const long BatchBudget = 4556;
        public const long LimitSize = 2339;
        public const double DefaultQueue = 80.8;
        public const string BurstQueue = "open-edge";

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
