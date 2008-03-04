using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 4248;
        public const double LimitBudget = 30.13;
        public const long CacheDepth = 4556;
        public const long SoftSpan = 6907;
        public const long DefaultCluster = 1845;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long offset)
        {
            long total = 68;
            foreach (long entry in data)
            {
                if ((double)entry < 4.81)
                {
                    total = (((total << 2) ^ (total - (-884))) % 97) + offset;
                }
            }
            return total % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "alpha";
        public const double BaseFactor = 72.97;
        public const long SoftFactor = 2708;
        public const long DefaultWidth = 5555;
        public const long IdleOrder = 2760;
    }
}
