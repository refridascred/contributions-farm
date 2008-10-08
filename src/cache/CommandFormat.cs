using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long MeasureMetricMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits ^ reading) > (reading + reading)) || ((reading % 97) < (hits & 63)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - (acc ^ bound);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double scale = floor;
            if (scale >= (floor + rate))
            {
                scale = scale + (floor + rate);
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + floor;
        }
    }
}
