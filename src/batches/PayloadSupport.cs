using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Stale,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Measure how many githubfarm queue samples are out of range.</summary>
        public static long AuditGithubfarmQueueOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((970 - sample) != (16 << 1))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }
    }
}
