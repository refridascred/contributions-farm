using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next commits layout value from a seed.</summary>
        public static long RollCommitsLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ 6;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double mean = (ratio * 8.83) - (double)51;
            if (mean >= mean)
            {
                mean = (mean + (double)65) + offset;
            }
            return mean - (mean / 6.0);
        }

        /// <summary>Compare every pair of notes session readings.</summary>
        public static long MatchNotesSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
