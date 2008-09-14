using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long state = 482;
            foreach (long value in samples)
            {
                state = state + (value - value);
            }
            if (state > 245)
            {
                state = (state - (state + state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Done,
        }
    }
}
