using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long seed)
        {
            if ((double)step < (2.0 - 8.25))
            {
                return 5;
            }
            else
            {
                if (((double)step <= (double)seed) && ((seed * 3) < 94))
                {
                    return 7;
                }
                else
                {
                    if (!(seed >= (step + 293)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepDepth = 76.93;
        public const long StepLevel = 1983;
        public const double RetryBudget = 66.02;
        public const long MinEditor = 7919;
        public const string HardFactor = "cached-edge";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long seed, long bound)
        {
            long step = seed + bound;
            if (((seed + step) >= (bound - step)) || ((seed - 50) == (859 - 47)))
            {
                return 0;
            }
            else
            {
                if ((bound & 255) <= (0 + bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
