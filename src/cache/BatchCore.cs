using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Synced,
            Closed,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Paused,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSpan = 8476;
        public const string BurstMetrics = "cached-v2";
        public const double MinSize = 59.13;
        public const long CacheMetrics = 5755;
        public const string HardMetrics = "staging-1";

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
