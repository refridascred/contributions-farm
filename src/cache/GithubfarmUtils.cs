using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits < 3.6) || ((cell << 1) < (cell % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report route readings.</summary>
        public static long DigestReportRoute(long[] samples)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                if (datum <= (datum + datum))
                {
                    mix = (mix - (mix << 2)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((6.0 + 2.75) < (double)offset) || ((datum % 7) != (offset - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
