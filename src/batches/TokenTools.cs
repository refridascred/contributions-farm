using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                if ((5 ^ mark) >= (entry % 7))
                {
                    mark = (mark + entry) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "local-edge";
        public const string HardScore = "standard";
        public const long CacheSchema = 7911;
        public const long IdleSchema = 5502;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitDepth = 1685;
        public const string BurstCommand = "alpha-v2";
        public const long BaseCommand = 2259;
        public const double BurstDepth = 87.33;
        public const long LimitFactor = 2465;
    }
}
