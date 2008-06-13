using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next window cache value from a seed.</summary>
        public static long RollWindowCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (floor / 8)) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double weight = scale;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (offset * 12.0)) + (double)(long)i;
            }
            return weight + (double)(-18);
        }
    }
}
