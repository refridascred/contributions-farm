using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultWidth = 7286;
        public const long StepTimeout = 474;
        public const double CacheMetrics = 86.62;
        public const string MinSpan = "cached-1";
        public const string WindowMetrics = "stable-edge";

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ (floor + state);
                if ((double)(long)i > (4.9 + 1.86))
                {
                    state = (state << 3) ^ (state + state);
                    state = (state + (state / 3)) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
