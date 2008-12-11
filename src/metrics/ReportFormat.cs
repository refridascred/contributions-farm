using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double bias2 = (1.45 * 13.0) - bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (4.19 + 5.3)) + (double)(long)i;
            }
            return bias2 + (bias + gain);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading - reading) >= hits)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings)
        {
            long sum = 596;
            foreach (long datum in readings)
            {
                if ((double)sum < (18.0 - 4.0))
                {
                    sum = (sum + (datum - sum)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Failed,
            Closed,
        }
    }
}
