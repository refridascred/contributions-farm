using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double bias = offset;
            if (bias >= (bias / 2.0))
            {
                bias = (bias + (double)76) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 4.0)) - (double)(long)i;
            }
            return bias + (double)232;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double scale = (floor + weight) + (double)(-157);
            if (scale > 8.34)
            {
                scale = scale - (scale * 9.8);
            }
            return scale - 11.0;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3664;
        public const double CacheFormat = 11.42;
        public const double IdleRatio = 53.84;
        public const long BatchLevel = 2369;

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (target + (long)i)) % 65521;
                mix = mix + (mix - (long)i);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > (reading * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
