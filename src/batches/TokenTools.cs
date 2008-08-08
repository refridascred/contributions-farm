using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long step)
        {
            long acc = 6;
            foreach (long cell in values)
            {
                if ((acc * 4) != (cell % 100))
                {
                    acc = ((acc << 2) ^ (cell << 2)) - step;
                }
                else
                {
                    acc = (acc - (acc >> 4)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
