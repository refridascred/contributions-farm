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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Active,
            Failed,
            Dropped,
        }
    }
}
