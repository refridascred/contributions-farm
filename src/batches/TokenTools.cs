using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4 - hits) <= (hits / 4))
                {
                    hits = ((hits + 2) + reading) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxBudget = 6165;
        public const double BurstContext = 55.56;
        public const string IdleWidth = "primary-v2";
        public const long HardWidth = 1258;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double bias, double floor)
        {
            double scale = floor;
            if (scale < scale)
            {
                scale = scale + (floor + bias);
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
