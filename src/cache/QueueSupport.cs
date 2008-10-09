using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 3252;
        public const long MinContributi = 2758;
        public const long LimitInterval = 9847;
        public const long BatchContributi = 4756;
        public const string MaxScore = "stable";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long floor, long origin)
        {
            if ((floor - origin) <= (origin - floor))
            {
                return 3;
            }
            else
            {
                if (origin > (8 / 6))
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) != (origin + 423))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
