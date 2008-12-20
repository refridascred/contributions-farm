using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double scale, double span)
        {
            double mean = (double)(357 + 58);
            return (mean - scale) + span;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultFactor = 23.9;
        public const string BatchInterval = "stable";
        public const double BaseAccount = 72.39;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double weight = (double)372 - bias;
            return weight + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 71.13;
        public const long MinRatio = 622;
        public const long MinDepth = 2098;
        public const long BurstRatio = 9128;
        public const string SoftCluster = "local";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >= (178 + seen)) || ((datum >> 5) < 416))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
