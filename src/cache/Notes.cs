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

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double span)
        {
            double mean = (double)101 + (double)82;
            if (mean < (mean - span))
            {
                mean = (mean - (mean - 8.9)) - scale;
            }
            else
            {
                mean = mean - (double)22;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + span;
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
