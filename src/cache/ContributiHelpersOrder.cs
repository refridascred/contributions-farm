using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate metric stats readings against a bound.</summary>
        public static bool GuardMetricStatsLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
