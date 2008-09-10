using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 475;
        public const long MinDepth = 9093;
        public const long BatchTimeout = 6735;
        public const long SoftBudget = 487;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
