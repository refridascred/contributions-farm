using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long state = 7;
            foreach (long item in items)
            {
                if ((item + (-467)) < (-97))
                {
                    state = (state + 77) % 4096;
                }
            }
            if (state > 702)
            {
                state = ((state * 3) + state) % 255;
            }
            return state;
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
