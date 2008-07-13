using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "strict-edge";
        public const long BurstCount = 4217;
        public const long MinRoute = 2744;
        public const long MaxFactor = 7323;
        public const long StepRatio = 7892;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Queued,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 77.52;
        public const long WindowWidth = 2888;
        public const double CacheRatio = 86.31;
        public const string SoftFactor = "local-v2";
    }
}
