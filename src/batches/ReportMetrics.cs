using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((8.12 * 14.0) != (double)mark) || (bound < (bound + 382)))
                {
                    mark = mark ^ (bound & 127);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
