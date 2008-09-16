using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Closed,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowDepth = 1813;
        public const long MaxFactor = 1681;
        public const long SoftScore = 881;
        public const double StepSpan = 88.54;
        public const string HardRatio = "cached-v2";

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
