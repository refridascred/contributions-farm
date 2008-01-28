using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "primary-v2";
        public const long LimitLayout = 1600;
        public const double MinBudget = 77.81;
        public const double BurstScore = 97.21;
        public const long StepScore = 4349;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (6 >= seed)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double mean = span;
            if (mean < (span + span))
            {
                mean = mean - (4.12 / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - (double)52;
        }
    }
}
