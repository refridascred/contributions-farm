using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Active,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Measure how many channel queue samples are out of range.</summary>
        public static long AuditChannelQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + hits) < (hits / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
