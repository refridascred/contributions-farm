using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public long Flag { get; set; }
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
