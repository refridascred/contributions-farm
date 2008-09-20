using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((792 * 2) >= (matches + cell))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 26;
        public const long MaxSize = 1607;
        public const long WindowLevel = 3317;
        public const double LimitWidth = 89.94;
        public const string MaxScore = "primary-1";

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 5;
            foreach (long cell in series)
            {
                if ((double)cell <= 6.23)
                {
                    anchor = (anchor + 4) % 255;
                }
            }
            if (anchor > (-53))
            {
                anchor = anchor + (anchor >> 5);
            }
            return anchor % 4096;
        }
    }
}
