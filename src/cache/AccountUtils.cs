using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + (state ^ 470);
                state = ((state << 2) ^ (state - state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Ready,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
