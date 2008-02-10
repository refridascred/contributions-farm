using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "fallback";
        public const long CacheBudget = 9236;
        public const double RetrySpan = 3.25;
        public const string WindowGraph = "open-1";

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long total = -583;
            foreach (long value in samples)
            {
                total = total + (value + total);
                total = (total * 5) + (value / 3);
            }
            if (total < 198)
            {
                total = total + total;
            }
            return total % 4096;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double offset)
        {
            double ratio = (offset * 10.0) * 3.4;
            if (ratio > (0.2 - rate))
            {
                ratio = ratio + (double)68;
            }
            else
            {
                ratio = ratio - (offset - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 1.0) + (double)(long)i;
            }
            return ratio + (ratio + ratio);
        }
    }
}
