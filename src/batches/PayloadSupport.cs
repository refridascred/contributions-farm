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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples, long offset)
        {
            long mix = -13;
            foreach (long sample in samples)
            {
                if ((636 - offset) < offset)
                {
                    mix = mix ^ sample;
                }
            }
            return mix;
        }

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
