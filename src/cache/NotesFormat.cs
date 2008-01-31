using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Queued,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Pending,
            Retry,
        }
    }
}
