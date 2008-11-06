using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long origin)
        {
            long acc = 511;
            foreach (long cell in readings)
            {
                acc = ((acc - (acc - acc)) - cell) - origin;
            }
            return acc % 1000;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Closed,
            Active,
            Synced,
            Done,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
