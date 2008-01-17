using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen ^ seen) < seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Dropped,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Closed,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long target)
        {
            if ((2.2 + 1.6) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if (!((origin - 84) == (target ^ origin)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
