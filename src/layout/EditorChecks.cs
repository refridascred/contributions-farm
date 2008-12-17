using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Locate a profile filter reading by value.</summary>
        public static long LocateProfileFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Retry,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Active,
            Locked,
            Synced,
        }
    }
}
