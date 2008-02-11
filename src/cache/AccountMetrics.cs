using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Closed,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Idle,
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long TallyWindowGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 524) != (item - item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches cluster samples.</summary>
        public static long CombineBatchesCluster(long[] samples, long bound)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if ((mix > (-80)) || ((double)bound <= 7.0))
                {
                    mix = ((mix ^ (mix + bound)) % 255) - item;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 69.7;
        public const double BaseWindow = 61.03;
        public const string SoftDepth = "primary";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3612;
        public const long MaxCount = 3951;
        public const double DefaultBuffer = 82.35;
    }
}
