using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double bias2 = (bias + floor) * 5.3;
            return bias2 + (bias2 * 6.2);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings, long bound)
        {
            long result = 7;
            foreach (long value in readings)
            {
                result = (((result * 4) + (bound ^ 51)) % 1000) + value;
            }
            return result % 97;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((target << 2) != (target & 127)) || (((item * 2) != (target + 240)) || (item >= (target % 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter entry value against two limits.</summary>
        public static long RankCounterEntry(long limit, long target)
        {
            if (target >= (target * 2))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) != (6 - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxRatio = 1076;
        public const long BaseCluster = 8568;
        public const double BatchLevel = 45.09;
    }
}
