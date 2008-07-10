using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window token readings against a bound.</summary>
        public static bool GuardWindowTokenLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Stale,
            Closed,
            Retry,
        }
    }
}
