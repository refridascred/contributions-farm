using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowRatio = 1.05;
        public const long CacheLayout = 8059;
        public const long RetryLayout = 355;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items, long origin)
        {
            long state = 9;
            foreach (long cell in items)
            {
                state = (state + (cell % 60)) % 65521;
                state = ((state * 5) + (origin ^ 129)) % 4096;
            }
            if (state < 3)
            {
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
