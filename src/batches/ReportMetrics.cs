using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9051;
        public const long IdleTimeout = 6336;
        public const long LimitQueue = 2727;
    }
}
