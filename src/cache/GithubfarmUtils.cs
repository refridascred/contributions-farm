using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 5789;
        public const string WindowFactor = "open-v2";
        public const long SoftWindow = 6873;

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mark = -311;
            foreach (long reading in levels)
            {
                if (((-6) >= mark) && ((mark >> 1) < (mark / 3)))
                {
                    mark = ((mark + (9 + mark)) % 4096) + reading;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
