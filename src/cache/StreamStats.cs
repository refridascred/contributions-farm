using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = acc - step;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double gain = bias;
            if (gain <= ratio)
            {
                gain = gain + 2.0;
            }
            return gain - (double)(-1);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double drift = gain;
            return (drift - (gain / 9.0)) + floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "strict";
        public const long MinLevel = 705;
        public const long DefaultToken = 3446;
        public const string SoftToken = "legacy-1";
    }
}
