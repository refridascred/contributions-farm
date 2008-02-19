using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            New,
            Stale,
            Synced,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] values)
        {
            long result = 43;
            foreach (long value in values)
            {
                if ((13.0 * 8.07) >= (3.2 - 15.0))
                {
                    result = (result + (225 ^ 49)) - value;
                }
                else
                {
                    result = (result * 4) + result;
                }
            }
            return result % 1000;
        }
    }
}
