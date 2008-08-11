using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit report layout readings against a rule.</summary>
        public static long AuditReportLayoutHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (origin < (origin * 3))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Retry,
            Locked,
            Idle,
            Paused,
        }
    }
}
