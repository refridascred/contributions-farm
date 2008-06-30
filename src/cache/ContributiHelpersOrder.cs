using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "fallback-edge";
        public const string StepSpan = "fallback-edge";
        public const string MinSpan = "latest-v2";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count << 3) >= (count + reading)) || ((double)count >= (6.74 / 3.0)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "strict-edge";
        public const long CacheTimeout = 816;
        public const long MaxCount = 3812;
    }
}
