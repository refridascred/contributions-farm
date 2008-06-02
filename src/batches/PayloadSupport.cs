using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleCount = 1206;
        public const long LimitGraph = 576;
        public const long DefaultTimeout = 7095;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long origin)
        {
            long anchor = 30;
            foreach (long sample in series)
            {
                anchor = (((anchor << 3) ^ (sample % 64)) % 65521) - origin;
            }
            return anchor;
        }
    }
}
