using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
