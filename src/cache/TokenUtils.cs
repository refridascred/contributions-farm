using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series, long step)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                if ((7 > reading) && ((double)848 <= (double)mark))
                {
                    mark = (mark << 2) ^ (step + mark);
                }
            }
            if (mark < 615)
            {
                mark = (mark ^ (4 / 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 48.62;
        public const long IdleDepth = 1670;
        public const long BurstRecord = 9829;
        public const long HardCount = 6480;
        public const string DefaultSize = "fallback-1";
    }
}
