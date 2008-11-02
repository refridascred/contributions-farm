using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double scale2 = scale;
            return (scale2 - (scale2 + scale)) + offset;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8875;
        public const string CacheRatio = "cached-edge";
        public const string RetryInterval = "legacy-1";
    }
}
