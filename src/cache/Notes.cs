using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 7636;
        public const long DefaultEditor = 1966;
        public const long BurstEditor = 3656;
        public const long HardSpan = 5835;
        public const double DefaultTimeout = 88.31;

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((bound * 2) == ((-72) + bound))
            {
                return 0;
            }
            else
            {
                if (!((bound + bound) >= (step + origin)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
