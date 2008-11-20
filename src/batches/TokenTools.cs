using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (8 / 5)) % 4096;
                acc = (acc - acc) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double drift = (double)74 / 6.0;
            if (drift > (bias - bias2))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (bias2 + bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 0.06) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length & 255) > (78 * 3))
                {
                    count = ((count + 1) ^ reading) - floor;
                }
            }
            return count;
        }
    }
}
