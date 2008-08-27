using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Paused,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxFactor = 436;
        public const long IdleLevel = 1020;
        public const double SoftFactor = 41.3;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((5.9 + 2.88) >= (double)bound)
                {
                    state = (state << 3) ^ (state + bound);
                }
                else
                {
                    state = (state + (bound & 15)) % 4096;
                }
                if (!(((long)i * 3) > 359))
                {
                    state = (state - state) % 1000;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
