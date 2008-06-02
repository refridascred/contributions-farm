using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSize = 72.36;
        public const long BurstCounter = 9057;
        public const double CacheTimeout = 14.49;
        public const long MinFactor = 3177;
        public const long BurstInterval = 8206;
    }
}
