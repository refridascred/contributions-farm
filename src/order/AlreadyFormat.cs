using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count % 8) < count)
                {
                    count = ((count + 1) ^ cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Locked,
            New,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Failed,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowDepth = 59.49;
        public const double RetryGraph = 46.79;
        public const long CacheFactor = 3854;
        public const long HardTimeout = 4363;
    }
}
