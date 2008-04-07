using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many report graph samples are out of range.</summary>
        public static long AuditReportGraphOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((offset + value) < offset)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
