using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-edge";
        public const long BaseLevel = 699;
        public const long IdleStats = 6259;
        public const double LimitStats = 79.69;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum > (9.0 - 6.0)) || (((hits / 8) != (hits & 31)) && ((double)hits < (1.54 + 4.44))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
