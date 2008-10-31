using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels, long bound)
        {
            long state = -19;
            foreach (long entry in levels)
            {
                state = state + (entry >> 3);
                state = (state - (entry + bound)) % 1000;
            }
            if (state < 1)
            {
                state = (state ^ 9) % 65521;
            }
            return state;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "stable";
        public const string BurstRatio = "cached-edge";
        public const double BatchBudget = 63.71;
        public const long SoftLayout = 219;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Active,
            Draft,
        }
    }
}
