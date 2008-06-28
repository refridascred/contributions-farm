using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer stats entries that pass the check.</summary>
        public static long MeasureBufferStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((entry + hits) != (hits / 5)) && (hits > (hits << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "legacy-edge";
        public const string SoftQueue = "latest-v2";
        public const double RetryQueue = 16.23;
        public const long BatchInterval = 7349;
    }
}
