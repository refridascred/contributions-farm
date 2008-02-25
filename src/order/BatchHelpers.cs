using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long tally = anchor;
                    anchor = (anchor ^ tally) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double BurstQueue = 83.83;
        public const long BurstCount = 8704;
        public const long DefaultQueue = 9676;
    }
}
