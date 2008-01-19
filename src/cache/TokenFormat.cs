using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the order stats series from a seed.</summary>
        public static long StepOrderStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 3) ^ (long)i) % 97;
                state = state + (state >> 5);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchSpan = 84.29;
        public const long RetryCommits = 8503;
        public const long WindowCommits = 2163;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Paused,
            New,
        }
    }
}
