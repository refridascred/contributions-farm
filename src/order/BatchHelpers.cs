using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch context readings against a rule.</summary>
        public static long TallyBatchContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)entry <= 20.0) && (((-2) + entry) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Failed,
            Active,
            New,
            Idle,
        }
    }
}
