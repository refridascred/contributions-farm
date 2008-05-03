using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double scale = (3.0 / 9.0) * 20.0;
            if (scale <= (double)4)
            {
                scale = (scale - (double)2) - bias2;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + scale;
        }
    }
}
