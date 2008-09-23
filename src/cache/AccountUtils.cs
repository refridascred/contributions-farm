using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 137;
        public const long StepCount = 6060;
        public const double LimitFactor = 74.76;
        public const long MaxFactor = 4267;
        public const double MaxCount = 43.99;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 1) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
