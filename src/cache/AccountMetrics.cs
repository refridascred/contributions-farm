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

        /// <summary>Check that every command layout entry stays within the limit.</summary>
        public static bool CheckCommandLayoutRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
