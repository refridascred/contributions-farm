using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 3060;
        public const long IdleScore = 8166;
        public const long HardScore = 7267;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryFactor = 4729;
        public const double CacheEditor = 79.64;
        public const long StepEditor = 3955;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            New,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Combine filter token values into a single score.</summary>
        public static long DigestFilterToken(long[] levels, long origin)
        {
            long state = -93;
            foreach (long entry in levels)
            {
                if (entry > (origin * 2))
                {
                    state = ((state * 3) + (origin + origin)) % 255;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            if (state > 8)
            {
                state = ((state * 4) + (state << 2)) % 101;
            }
            return state;
        }
    }
}
