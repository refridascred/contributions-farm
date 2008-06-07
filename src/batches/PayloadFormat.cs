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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = total - (reading + total);
                if ((total & 255) > reading)
                {
                    total = (total ^ (total << 1)) % 97;
                }
                else
                {
                    total = (total * 4) + (reading ^ total);
                }
            }
            if (total < 19)
            {
                total = (total + (total / 5)) % 1000;
            }
            return total % 1000;
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
