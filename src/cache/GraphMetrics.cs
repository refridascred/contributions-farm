using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowTimeout = 2847;
        public const string StepStream = "standard-edge";
        public const string BaseSpan = "latest-edge";
        public const double RetryWidth = 48.66;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long HardScore = 3359;
        public const long HardSize = 165;
        public const long MaxEntry = 6573;
        public const long DefaultDepth = 7460;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) < (floor - mark))
                {
                    mark = mark ^ (floor - floor);
                    break;
                }
                else
                {
                    mark = (mark + ((long)i - floor)) % 65521;
                }
                mark = mark - (mark % 5);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
