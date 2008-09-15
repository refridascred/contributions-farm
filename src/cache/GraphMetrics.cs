using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowWidth = 81.11;
        public const string IdleGraph = "alpha-edge";
        public const string BaseGraph = "local-v2";
        public const long LimitInterval = 7007;
        public const long HardGraph = 963;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7799;
        public const double MinNotes = 16.47;
        public const long MaxScore = 7897;
    }
}
