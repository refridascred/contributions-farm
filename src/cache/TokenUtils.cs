using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstDepth = 1546;
        public const long LimitFactor = 7485;
        public const long MaxContext = 3899;
        public const string WindowContext = "standard-v2";

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
