using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long AuditTokenMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!!((seen ^ 57) >= seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((offset % 100) <= (seen << 3))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
