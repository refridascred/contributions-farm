using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next counter command value.</summary>
        public static double SmoothCounterCommand(double bias, double floor)
        {
            double gain = (double)((-911) - 54);
            if (gain >= (floor / 5.0))
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor / 6.0)) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches & 7) < matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 8565;
        public const long BatchFactor = 3211;
        public const double CacheSession = 54.04;
    }
}
