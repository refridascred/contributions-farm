using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool GuardTokenSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
