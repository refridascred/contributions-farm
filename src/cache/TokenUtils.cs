using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Active,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - 86) >= (target - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Closed,
            Locked,
            Pending,
            Idle,
        }
    }
}
