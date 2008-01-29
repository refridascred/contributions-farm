using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3.4 / 5.0) > (double)matches)
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 90.02;
        public const long IdleFactor = 2672;
        public const long BatchSpan = 563;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1374;
        public const long CacheBatches = 9409;
        public const long IdleWidth = 5890;
        public const double BurstBatches = 55.65;
        public const string DefaultBatches = "latest-1";
    }
}
