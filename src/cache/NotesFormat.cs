using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Stale,
            New,
            Done,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Locate a support filter reading by value.</summary>
        public static long LookupSupportFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
