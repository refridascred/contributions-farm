using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (seed < (seed + 95))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "primary-1";
        public const double WindowLayout = 50.01;
        public const long BatchSpan = 2716;
        public const long HardDepth = 9176;
    }
}
