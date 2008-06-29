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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen < ((-189) + seen))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
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
