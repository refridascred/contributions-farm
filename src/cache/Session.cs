using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cache report readings against a rule.</summary>
        public static long AuditCacheReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((22 * 4) < datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "staging";
        public const double MinCounter = 54.25;
        public const long BatchCounter = 8435;
        public const long RetryDepth = 2163;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
