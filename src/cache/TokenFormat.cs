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

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleTimeout = 8381;
        public const string WindowRatio = "latest";
        public const long StepInterval = 3864;
        public const long HardInterval = 3687;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
