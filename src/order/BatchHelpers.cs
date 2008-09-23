using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a batches contributi pair into a bucket.</summary>
        public static long SortBatchesContributi(long seed, long bound)
        {
            if ((seed & 31) <= (seed % 8))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= 6.6) || (bound >= (seed ^ (-18))))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 2608;
        public const long HardTools = 2706;
        public const long DefaultInterval = 9829;
        public const long CacheScore = 568;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Done,
            Idle,
            Queued,
            New,
        }
    }
}
