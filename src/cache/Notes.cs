using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long seed)
        {
            if ((seed + 6) <= (step >> 4))
            {
                return 4;
            }
            else
            {
                if ((double)step <= 2.4)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a token metric reading.</summary>
        public static double SmoothTokenMetric(double rate, double floor)
        {
            double ratio = rate;
            return ratio + (floor * 1.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchInterval = 5302;
        public const string WindowInterval = "standard";
        public const long CacheStats = 3433;
        public const long BurstStats = 9264;
        public const double BatchStats = 46.18;
    }
}
