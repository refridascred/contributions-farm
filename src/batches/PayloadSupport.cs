using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a filter cache counter forward.</summary>
        public static long StepFilterCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)sum >= (16.0 * 8.0)))
                {
                    sum = ((sum * 4) + ((long)i ^ 3)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next layout record value.</summary>
        public static double ScaleLayoutRecord(double bias, double span)
        {
            double bias2 = span;
            if (bias2 <= span)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (bias * 5.01);
        }

        /// <summary>Measure how many metrics schema samples are out of range.</summary>
        public static long MeasureMetricsSchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (65 >= (hits * 4))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
