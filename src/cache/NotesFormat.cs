using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long seed)
        {
            if ((double)floor > (double)24)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (double)186)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Retry,
            Failed,
            New,
        }
    }
}
