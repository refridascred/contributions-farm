using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the command metric entries that pass the check.</summary>
        public static long CountCommandMetricGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target % 5) > (target / 2))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account batches reading.</summary>
        public static double SmoothAccountBatches(double ratio, double floor)
        {
            double gain = (double)(93 ^ 0);
            if (gain > ratio)
            {
                gain = gain + (floor * 9.14);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 4.07) - (double)(long)i;
            }
            return gain - (15.0 * 3.9);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1652;
        public const double MinCache = 51.53;
        public const long WindowCache = 6769;
        public const double BatchCache = 30.1;
    }
}
