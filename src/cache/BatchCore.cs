using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 51.94;
        public const string BatchScore = "local-1";
        public const string IdleBudget = "strict";
        public const long CacheInterval = 8390;
        public const long MaxInterval = 2801;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Queued,
            Pending,
            Done,
            Active,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample & 31) <= (sample << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Retry,
            Locked,
            Queued,
            New,
        }
    }
}
