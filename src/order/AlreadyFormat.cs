using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (16.0 * 3.66))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Validate githubfarm route readings against a bound.</summary>
        public static bool GuardGithubfarmRouteLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels)
        {
            long mark = -1;
            foreach (long entry in levels)
            {
                if ((mark + mark) == (long)levels.Length)
                {
                    mark = mark - entry;
                    mark = mark + (entry << 1);
                }
                mark = mark + entry;
                if ((mark < (mark << 3)) && ((12.0 + 18.0) >= (double)entry))
                {
                    break;
                }
            }
            if (mark > 460)
            {
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
