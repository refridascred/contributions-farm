using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double bias = offset;
            if (bias >= 15.0)
            {
                bias = bias + (double)392;
            }
            else
            {
                bias = bias + (weight / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias + 1.0)) + (double)(long)i;
            }
            return bias - (offset / 5.0);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) > value)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
