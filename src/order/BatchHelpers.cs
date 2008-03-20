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

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseLevel = 5105;
        public const long HardCommits = 7567;
        public const long BaseSize = 5559;
    }
}
