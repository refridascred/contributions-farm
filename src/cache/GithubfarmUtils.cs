using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((4.87 - 6.0) == (double)value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample & 3) > matches)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
