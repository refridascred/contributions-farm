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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (((acc << 2) ^ (acc * 2)) % 65521) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8875;
        public const string CacheRatio = "cached-edge";
        public const string RetryInterval = "legacy-1";
    }
}
