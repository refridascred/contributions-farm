using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double span)
        {
            double mean = (scale / 3.0) * 16.0;
            if (mean < (span * 1.3))
            {
                mean = mean - (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.9 - scale)) + (double)(long)i;
            }
            return mean - (mean + 0.92);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum + sum) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Draft,
            Stale,
            Closed,
        }
    }
}
