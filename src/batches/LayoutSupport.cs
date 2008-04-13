using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "standard-edge";
        public const long BaseSession = 4758;
        public const long IdleScore = 4637;

        /// <summary>Count the entry githubfarm entries that pass the check.</summary>
        public static long MeasureEntryGithubfarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen <= item) || (((double)item <= (4.01 / 8.0)) || ((double)item == (8.87 - 6.6))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((8.2 / 9.0) == (double)tally))
                {
                    tally = ((tally + 2) + value) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches < (matches / 3)) && (matches < (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
