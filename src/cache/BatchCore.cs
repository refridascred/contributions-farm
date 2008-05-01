using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches >> 1) <= origin)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 20.78;
        public const double CacheSchema = 13.2;
        public const string CacheBudget = "stable-1";
        public const string MaxSchema = "strict";
        public const double IdleSchema = 77.92;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "fallback";
        public const string RetryChannel = "legacy";
        public const long MinChannel = 691;
        public const double BaseSize = 91.37;
    }
}
