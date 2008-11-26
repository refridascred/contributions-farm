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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepRatio = "open-edge";
        public const long MaxBuffer = 1645;
        public const long DefaultBuffer = 5825;
        public const long BatchBuffer = 4459;
        public const long SoftBuffer = 2792;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + value) <= (count << 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
