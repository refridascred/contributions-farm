using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultBudget = "latest";
        public const double LimitGithubfarm = 28.99;
        public const double StepFactor = 52.24;
        public const double IdleScore = 1.26;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (0 >= (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Queued,
            Stale,
            Retry,
        }
    }
}
