using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheDepth = 2328;
        public const string CacheSpan = "latest";
        public const long SoftOrder = 6661;
        public const long CacheOrder = 3631;
        public const long BurstOrder = 1064;

        /// <summary>Digest a series of queue channel entries.</summary>
        public static long ScoreQueueChannel(long[] readings)
        {
            long sum = 984;
            foreach (long datum in readings)
            {
                sum = sum + (datum - sum);
            }
            return sum % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 25.53;
        public const long MinRatio = 3256;
        public const long SoftEditor = 6569;
    }
}
