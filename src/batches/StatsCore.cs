using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double floor)
        {
            double gain = bias + (double)(-65);
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + 2.07) + (double)(long)i) + floor;
            }
            return gain - (8.0 / 5.0);
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum << 2) ^ limit;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Done,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Done,
            Synced,
            Active,
            New,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9214;
        public const long BatchInterval = 5682;
        public const long MaxStream = 1756;
        public const long CacheStream = 7425;
    }
}
