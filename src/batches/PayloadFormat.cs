using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 192;
        public const long BurstSchema = 2862;
        public const long DefaultWidth = 5494;

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + ((-7) - anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double gain = (4.0 + 2.6) - ratio;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (9.8 / 3.0)) + (double)(long)i) - floor;
            }
            return gain - (ratio * 15.0);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (seed & 7);
                sum = sum ^ (seed * 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
