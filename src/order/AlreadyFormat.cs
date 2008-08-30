using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a farm account sample.</summary>
        public static long LookupFarmAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "stable-v2";
        public const long BurstLevel = 8386;
        public const long MaxCommits = 3389;
        public const long StepCommits = 919;
        public const long BaseCommits = 739;

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long TallyOrderSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) <= 11)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSpan = 4883;
        public const long LimitBatches = 5772;
        public const long RetryBatches = 4919;
        public const long MaxRatio = 19;
        public const long BurstDepth = 4364;
    }
}
