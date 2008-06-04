using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double weight = ratio - (ratio * 6.0);
            return weight - floor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series, long seed)
        {
            long mark = -55;
            foreach (long value in series)
            {
                mark = (((mark * 2) + (80 / 3)) - value) - seed;
            }
            return mark;
        }

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long MeasureLayoutClusterHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((cell * 4) < cell) || (seen <= ((long)data.Length - 0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
