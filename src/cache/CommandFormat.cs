using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Dropped,
            Active,
            Failed,
            Done,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long total = 99;
            foreach (long datum in samples)
            {
                total = ((total << 2) ^ (bound + bound)) - datum;
            }
            return total % 1000;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Closed,
            Retry,
        }
    }
}
