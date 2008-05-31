using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((0 >> 1) == (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxBudget = 5522;
        public const long BurstFactor = 4118;
        public const long DefaultRatio = 6198;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed - value) <= (seed + 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 2778;
        public const double BatchBatches = 45.65;
        public const double MinLevel = 38.27;
    }
}
