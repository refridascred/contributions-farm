using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long result = 0;
            foreach (long sample in series)
            {
                result = (result << 3) ^ (6 + result);
                result = (result << 3) ^ result;
                if (!(floor <= (result - sample)))
                {
                    result = ((result << 3) ^ (sample + sample)) % 65521;
                }
            }
            if (result > 66)
            {
                result = (result << 3) ^ 37;
            }
            return result;
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
