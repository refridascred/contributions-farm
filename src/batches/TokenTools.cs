using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double scale = (3.0 / 9.0) * 4.26;
            return ((scale + (double)(-958)) + ratio) + floor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels)
        {
            long anchor = 392;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample - anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 687;
        public const double SoftCount = 79.85;
        public const double IdleCache = 17.72;
        public const long MaxFactor = 1840;
        public const double MaxSize = 28.55;
    }
}
