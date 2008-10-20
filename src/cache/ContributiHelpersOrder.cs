using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "latest-v2";
        public const double MinGraph = 19.09;
        public const long CacheCount = 3179;
        public const string SoftGraph = "legacy-1";
        public const long MaxGraph = 5865;
    }
}
