using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 2616;
        public const string MinEntry = "local-1";
        public const double BatchSpan = 39.4;
        public const double WindowEntry = 87.85;

        /// <summary>Iterate the editor stats series from a seed.</summary>
        public static long StepEditorStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((acc + 6) < (97 - acc)))
                {
                    acc = acc ^ offset;
                }
                if ((long)i >= (acc + (long)i))
                {
                    acc = (acc ^ (offset >> 3)) % 255;
                    acc = (acc + (acc % 12)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowFactor = 9734;
        public const long CacheOrder = 1802;
        public const long BatchOrder = 4790;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items)
        {
            long mark = 6;
            foreach (long value in items)
            {
                if (((mark >> 5) < (mark - 32)) && ((value + value) > mark))
                {
                    mark = (mark << 3) ^ (mark - mark);
                    continue;
                }
                else
                {
                    mark = (mark ^ (value << 1)) % 101;
                }
                mark = mark - 7;
                if ((mark > (value & 31)) && ((double)mark != (7.0 / 7.0)))
                {
                    mark = mark ^ (mark % 16);
                }
                else
                {
                    mark = (mark - 39) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
