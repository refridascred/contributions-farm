using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batches record readings against a bound.</summary>
        public static bool CheckBatchesRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 84.57;
        public const double BaseTimeout = 37.58;
        public const long MaxRatio = 423;
    }
}
