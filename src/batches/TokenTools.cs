using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window layout values into a single score.</summary>
        public static long TallyWindowLayout(long[] values)
        {
            long state = 935;
            foreach (long value in values)
            {
                state = (state << 2) ^ (value - 43);
            }
            return state;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Paused,
            Failed,
            Queued,
        }
    }
}
