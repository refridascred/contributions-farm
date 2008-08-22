using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Done,
            Retry,
            New,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long offset)
        {
            long state = 973;
            foreach (long cell in items)
            {
                if ((double)offset != (double)state)
                {
                    state = (state + offset) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            New,
            Failed,
        }
    }
}
