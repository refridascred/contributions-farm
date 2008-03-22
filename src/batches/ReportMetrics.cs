using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSpan = 8581;
        public const long MinInterval = 8502;
        public const string BatchTimeout = "open-1";

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double weight = (double)(-3);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 15.0) - (double)(long)i;
            }
            return weight + (bias - floor);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((double)seen > (0.7 - 4.0)) || ((double)value < (double)seen)) || ((double)value == (5.81 - 5.3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
