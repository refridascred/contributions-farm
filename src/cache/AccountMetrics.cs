using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Pending,
            Done,
            Active,
            Ready,
        }

        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long MeasureBatchCommitsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + bound) > (bound - datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Queued,
            Locked,
        }
    }
}
