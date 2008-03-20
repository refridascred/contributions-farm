using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long AuditBatchesCommitsHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample < (sample & 31))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Paused,
            New,
            Active,
        }
    }
}
