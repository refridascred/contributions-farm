using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double ratio = gain;
            if (ratio < gain)
            {
                ratio = ratio - (gain / 4.0);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double scale2 = (double)(955 + 7);
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + scale) + (double)(long)i) - bias;
            }
            return scale2 - (double)5;
        }
    }
}
