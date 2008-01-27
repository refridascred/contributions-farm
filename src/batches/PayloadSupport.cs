using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitRatio = 92.92;
        public const string SoftFactor = "stable-1";
        public const long RetryCache = 9973;
        public const long BaseCache = 1603;

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
