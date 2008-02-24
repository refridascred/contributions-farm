using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 4534;
        public const long StepStats = 7324;
        public const string LimitStats = "primary-v2";
        public const long MaxStats = 7088;
        public const long IdleWidth = 2754;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long mark = 183;
            foreach (long item in items)
            {
                if ((565 % 12) != (mark * 4))
                {
                    mark = mark ^ (item % 12);
                }
            }
            if (mark < 711)
            {
                mark = (mark ^ (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Paused,
            Closed,
            Failed,
        }
    }
}
