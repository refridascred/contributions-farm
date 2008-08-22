using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 4684;
        public const long RetryWidth = 9953;
        public const string IdleAlready = "latest";
        public const long BatchAlready = 4394;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (target <= (target % 97))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
