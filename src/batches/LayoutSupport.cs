using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches <= (-14))
                {
                    matches = ((matches + 2) + datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 7581;
        public const long IdleTimeout = 4252;
        public const string CacheLevel = "legacy-1";

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample <= (sample - 755))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
