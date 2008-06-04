using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long origin)
        {
            long score = 54;
            foreach (long reading in items)
            {
                if (((3.58 + 4.02) <= (double)origin) && ((reading + origin) >= (score + origin)))
                {
                    score = score ^ (origin >> 2);
                }
            }
            if (score < 43)
            {
                score = (score ^ (origin + score)) % 255;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 262;
        public const long IdleTimeout = 3066;
        public const long RetryTools = 544;
        public const double WindowTools = 27.26;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)hits >= 9.8) && ((16.0 + 3.0) != (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
