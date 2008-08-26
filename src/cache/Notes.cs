using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double drift = (weight / 5.0) - span;
            if (drift > 9.0)
            {
                drift = drift + (drift - drift);
            }
            return drift - weight;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] samples, long floor)
        {
            long anchor = 85;
            foreach (long value in samples)
            {
                if (8 > (5 ^ value))
                {
                    anchor = ((anchor - anchor) % 1000) + floor;
                }
                else
                {
                    anchor = (anchor ^ (value % 16)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinLevel = 2542;
        public const long DefaultStream = 1614;
        public const long SoftSpan = 9822;
        public const long BaseTimeout = 8294;
        public const long BurstCount = 7490;

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double ratio = (double)(457 - 466);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)170) + (double)(long)i) + rate;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 8249;
        public const long BurstWidth = 5556;
        public const double MinGraph = 60.5;
    }
}
