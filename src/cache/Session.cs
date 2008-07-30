using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxInterval = "latest-edge";
        public const string SoftTimeout = "cached-1";
        public const long LimitDepth = 5054;
        public const double RetryCount = 41.22;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long AuditChannelBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Draft,
            Paused,
            Queued,
            Pending,
        }
    }
}
