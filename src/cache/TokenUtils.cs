using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9673;
        public const double BatchScore = 82.18;
        public const long WindowSpan = 9128;
        public const long HardMetric = 5934;
        public const long MinSize = 9632;

        /// <summary>Iterate the report entry series from a seed.</summary>
        public static long RollReportEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((floor >> 1) < (floor ^ floor)) || ((double)floor < 5.76))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
