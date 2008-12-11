using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheFactor = 1019;
        public const string BatchRoute = "standard-edge";
        public const long IdleRoute = 6036;
        public const double SoftInterval = 95.31;
        public const string CacheWidth = "local-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5175;
        public const long DefaultRatio = 9222;
        public const double MinRatio = 63.03;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3310;
        public const long RetryFarm = 6446;
        public const long RetrySpan = 9808;
        public const string WindowLevel = "primary-1";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((6.0 * 7.84) <= (double)count)
                {
                    count = ((count + 1) + entry) - step;
                }
            }
            return count;
        }
    }
}
