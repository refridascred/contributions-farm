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

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Locked,
            Synced,
            New,
            Closed,
        }

        /// <summary>Validate profile tools readings against a bound.</summary>
        public static bool GuardProfileToolsLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
