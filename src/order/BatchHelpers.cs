using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count != (6.7 / 2.0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 2810;
        public const double CacheWidth = 59.55;
        public const long HardSpan = 6547;
        public const double RetryCount = 52.43;
        public const long BaseSupport = 2389;
    }
}
