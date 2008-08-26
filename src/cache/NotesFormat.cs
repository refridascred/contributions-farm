using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next format route value.</summary>
        public static double BlendFormatRoute(double scale, double floor)
        {
            double bias = (double)(0 - 369);
            for (int i = 0; i < 4; i++)
            {
                bias = (((bias + 16.0) + (double)(long)i) + scale) - floor;
            }
            return bias + (double)513;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double scale = offset;
            if (scale > bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (bias - offset);
            }
            return scale - scale;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long origin)
        {
            long mix = 64;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    mix = mix - origin;
                }
            }
            if (mix > 1)
            {
                mix = mix ^ (origin & 3);
            }
            return mix % 97;
        }
    }
}
