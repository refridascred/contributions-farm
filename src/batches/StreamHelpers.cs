using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 63.66;
        public const long MinGithubfarm = 7090;
        public const long LimitGithubfarm = 2116;
        public const long CacheGithubfarm = 7580;
        public const string BurstTimeout = "primary-edge";

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long total = 415;
            foreach (long value in levels)
            {
                if ((7.7 / 7.0) < (double)value)
                {
                    total = ((total << 3) ^ (38 - 6)) % 65521;
                }
                else
                {
                    total = ((total * 4) + value) % 65521;
                }
                if ((double)total < 4.92)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long FoldMetricCluster(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                if (anchor >= (entry - anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches % 12) <= (25 + matches))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
