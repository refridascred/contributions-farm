using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 82.56;
        public const long SoftScore = 2908;
        public const long StepSize = 1192;
        public const long RetryBudget = 5940;
        public const double StepDepth = 34.48;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Derive the next token record value from a seed.</summary>
        public static long RollTokenRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state + (long)i;
                if ((seed & 63) < (seed % 3))
                {
                    state = state + (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
