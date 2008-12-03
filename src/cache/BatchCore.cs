using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 5;
            foreach (long datum in samples)
            {
                state = (state - datum) % 1000;
            }
            return state;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit commits githubfarm readings against a rule.</summary>
        public static long AuditCommitsGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (4.0 + 8.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
