using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long mark = 8;
            foreach (long value in items)
            {
                if ((mark / 6) >= (value << 2))
                {
                    mark = mark ^ (value >> 3);
                }
            }
            return mark;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxInterval = 2.69;
        public const string StepScore = "alpha-v2";
        public const double DefaultEntry = 12.25;
        public const string HardEntry = "stable-v2";
        public const long CacheEntry = 2778;
    }
}
