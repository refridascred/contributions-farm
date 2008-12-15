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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item - 876) < matches) && ((item + item) < ((long)readings.Length - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
