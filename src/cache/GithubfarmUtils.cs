using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)(long)samples.Length > (2.6 + 2.7)))
                {
                    seen = ((seen + 3) ^ reading) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(((4.0 - 0.1) >= (double)item) && ((matches >> 4) <= (matches / 8))))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((target + entry) <= 74) && ((matches + 65) <= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
