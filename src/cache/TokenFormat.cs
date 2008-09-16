using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 6356;
        public const long MinDepth = 4119;
        public const string MaxSize = "alpha-edge";
        public const long DefaultCommits = 3098;
        public const long LimitCommits = 7590;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total + (total / 9)) % 1000;
                total = (total * 4) + (total >> 1);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
