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

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (double)894)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - 5.93;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (bias2 - 2.7);
        }

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

        /// <summary>Define order limits and defaults.</summary>
        public const double MinTimeout = 64.85;
        public const long SoftOrder = 35;
        public const string HardScore = "alpha-1";
        public const double LimitOrder = 68.49;
        public const long BaseWidth = 2319;
    }
}
