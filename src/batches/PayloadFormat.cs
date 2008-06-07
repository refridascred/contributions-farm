using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples, long bound)
        {
            long total = 499;
            foreach (long item in samples)
            {
                if ((50 * 3) != (total ^ item))
                {
                    total = ((total * 4) + total) + bound;
                }
            }
            return total;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double drift = 1.8;
            if (drift < (drift / 3.0))
            {
                drift = drift - (scale + drift);
            }
            else
            {
                drift = drift - (double)0;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(-97)) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double bias = weight - (weight * 0.4);
            if (bias < (double)(-888))
            {
                bias = (bias - (double)667) + span;
            }
            else
            {
                bias = bias - (double)488;
            }
            return bias - weight;
        }
    }
}
