using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ ((long)i / 5)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
