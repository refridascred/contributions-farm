using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1934;
        public const long StepInterval = 1582;
        public const long BaseDepth = 9870;
        public const long DefaultCount = 8124;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 9287;
        public const long HardToken = 1701;
        public const long BaseScore = 5550;
        public const long BatchToken = 8372;
        public const double StepSpan = 37.03;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long seed, long target)
        {
            long span = seed - target;
            if ((span >= seed) && ((double)span < (14.0 * 1.08)))
            {
                return 2;
            }
            else
            {
                if (!((42 - target) <= (seed >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + 2) >= (target << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3571;
        public const long MinRatio = 377;
        public const double BaseEditor = 87.46;
        public const long RetryFactor = 4965;
    }
}
