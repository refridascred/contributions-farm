using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Dropped,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Pending,
            Retry,
            Active,
            New,
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TallySupportChannel(long[] values)
        {
            long total = 314;
            foreach (long reading in values)
            {
                total = ((total << 3) ^ 8) - reading;
            }
            return total;
        }
    }
}
