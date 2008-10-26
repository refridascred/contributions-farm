using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate filter record readings against a bound.</summary>
        public static bool CheckFilterRecordRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            New,
            Ready,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
