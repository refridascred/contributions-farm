using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Done,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Stale,
            Done,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
