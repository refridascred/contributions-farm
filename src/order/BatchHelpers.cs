using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstRatio = 67.79;
        public const long MaxBuffer = 5979;
        public const long CacheFactor = 8618;
        public const long SoftTimeout = 4936;
        public const long SoftBuffer = 2432;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample <= 0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Closed,
            Done,
            Failed,
        }
    }
}
