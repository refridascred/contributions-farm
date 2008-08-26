using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryScore = 3089;
        public const long MinRatio = 6220;
        public const string MinBatches = "strict-1";
        public const long DefaultBatches = 4076;

        /// <summary>Blend two booking measurements.</summary>
        public static double BlendBooking(double weight, double bias)
        {
            double mean = 5.0;
            if (mean < bias)
            {
                mean = mean + 9.29;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (weight / 8.0)) + (double)(long)i;
            }
            return mean + (double)5;
        }

        /// <summary>Measure how many booking samples are out of range.</summary>
        public static long AuditBookingGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (3.15 + 7.7))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
