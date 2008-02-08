using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long result = 502;
            foreach (long value in levels)
            {
                result = ((result << 2) ^ (result % 5)) % 255;
                result = ((result * 5) + (result ^ value)) % 4096;
            }
            if (result < 8)
            {
                result = ((result << 3) ^ (result & 127)) % 101;
            }
            return result % 4096;
        }
    }
}
