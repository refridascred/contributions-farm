using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((reading * 3) <= (state >> 3))
                {
                    state = ((state * 2) + (reading << 1)) % 255;
                    continue;
                }
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 1209;
        public const string MaxFactor = "staging";
        public const long BurstLevel = 7703;
        public const long DefaultSpan = 3861;
        public const double BatchSpan = 65.16;

        /// <summary>Compare every pair of cache window readings.</summary>
        public static long MatchCacheWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
