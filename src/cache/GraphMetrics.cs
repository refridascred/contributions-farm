using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9421;
        public const string SoftSize = "staging";
        public const double SoftBudget = 54.49;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((datum << 3) == (matches + datum)) && ((matches * 3) != (469 & 31))) || !((datum - datum) < datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry report entry stays within the limit.</summary>
        public static bool GuardEntryReportBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((9 + reading) < (98 + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
