using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit farm support readings against a rule.</summary>
        public static long CountFarmSupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches ^ matches) > (reading & 15)) || (((matches - reading) != (reading / 5)) && (reading <= (reading % 60))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            New,
            Paused,
            Stale,
            Retry,
        }
    }
}
