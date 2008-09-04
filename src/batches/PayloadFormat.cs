using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (sum + floor)) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double gain = (double)(3 - 7);
            if (gain > (bias - 8.58))
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + weight)) + (double)(long)i;
            }
            return gain + (weight - bias);
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double bias = (double)(8 >> 2);
            if (bias > 1.02)
            {
                bias = ((bias + (double)816) + ratio) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 17.0) + (double)(long)i;
            }
            return bias - (bias * 5.0);
        }
    }
}
