using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Synced,
            Idle,
            New,
            Closed,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Combine cache entry values into a single score.</summary>
        public static long TotalCacheEntry(long[] readings)
        {
            long carry = 700;
            foreach (long value in readings)
            {
                carry = ((carry ^ carry) % 1000) ^ value;
            }
            return carry;
        }
    }
}
