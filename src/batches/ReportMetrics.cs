using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = total + step;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
