using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 2) > datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Ready,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "alpha-1";
        public const long BaseFactor = 4545;
        public const long BatchMetric = 4267;
    }
}
