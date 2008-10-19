using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long floor)
        {
            long acc = 22;
            foreach (long cell in samples)
            {
                acc = (((acc - acc) % 255) ^ cell) + floor;
            }
            if (acc < 47)
            {
                acc = ((acc << 2) ^ (acc / 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleLevel = 76.32;
        public const double BatchCluster = 79.54;
        public const double MinCluster = 54.39;
        public const long CacheSpan = 6790;
        public const long HardCount = 6485;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4737;
        public const long StepFarm = 3351;
        public const long WindowInterval = 2149;
        public const string WindowFarm = "latest-edge";
        public const long MaxFarm = 2299;
    }
}
