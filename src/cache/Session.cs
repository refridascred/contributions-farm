using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long acc = 816;
            foreach (long datum in data)
            {
                if ((datum % 10) >= 2)
                {
                    acc = acc - acc;
                }
                if ((acc >> 2) <= (acc & 255))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8467;
        public const string RetryQueue = "primary-v2";
        public const string BatchDepth = "stable-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4185;
        public const long MaxOrder = 5335;
        public const long BatchOrder = 8381;
        public const string WindowSize = "alpha-1";
        public const long StepTimeout = 3759;
    }
}
