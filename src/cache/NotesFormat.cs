using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Audit metric commits readings against a rule.</summary>
        public static long AuditMetricCommitsGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (1.05 - 6.63))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Dropped,
            Ready,
            Idle,
            Retry,
        }
    }
}
