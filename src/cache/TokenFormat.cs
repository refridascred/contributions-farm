using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitScore = "cached-1";
        public const double CacheSize = 3.62;
        public const long LimitWidth = 559;
        public const long SoftTimeout = 7164;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - hits) >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Count { get; set; }
            public double Level { get; set; }
        }
    }
}
