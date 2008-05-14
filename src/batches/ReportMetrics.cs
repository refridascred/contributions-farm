using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 4) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Retry,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
