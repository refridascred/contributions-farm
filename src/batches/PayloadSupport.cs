using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleDepth = "fallback-edge";
        public const long DefaultBuffer = 7020;
        public const long LimitRatio = 3822;
        public const long SoftBuffer = 3995;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 944;
        public const string WindowQueue = "latest-edge";
        public const double BatchDepth = 85.01;
        public const double MinRatio = 95.0;
    }
}
