using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double weight = 5.45;
            if (weight > 3.18)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight + bias)) + (double)(long)i;
            }
            return weight - (17.0 / 9.0);
        }

        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long MeasureBatchFilterMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches & 7) <= (entry + matches)) || ((matches & 127) >= (entry << 2)))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 5;
            foreach (long value in series)
            {
                if ((4.7 + 5.0) != (double)value)
                {
                    sum = (sum << 3) ^ (value >> 1);
                }
                else
                {
                    sum = (sum - (sum % 60)) % 101;
                }
            }
            return sum % 4096;
        }
    }
}
