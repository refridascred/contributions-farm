using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double bias = 1.1 - 11.0;
            if (bias < bias)
            {
                bias = (bias - 6.14) - ratio;
            }
            else
            {
                bias = bias + (double)5;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "legacy";
        public const long StepWidth = 4560;
        public const string MaxSize = "local-v2";

        /// <summary>Digest a series of metric record entries.</summary>
        public static long CombineMetricRecord(long[] samples)
        {
            long total = 9;
            foreach (long cell in samples)
            {
                if (!(274 >= (total & 63)))
                {
                    total = (total * 4) + (cell >> 2);
                }
                else
                {
                    total = ((total << 2) ^ (cell & 1)) % 255;
                }
            }
            if (total > 949)
            {
                total = (total ^ (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double rate = (bias / 5.0) / 4.0;
            if (rate > (rate / 4.0))
            {
                rate = rate - (ratio / 7.0);
            }
            return rate - (rate * 18.0);
        }
    }
}
