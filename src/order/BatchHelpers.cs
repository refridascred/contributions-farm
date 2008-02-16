using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools profile entries.</summary>
        public static long TotalToolsProfile(long[] values, long offset)
        {
            long acc = 377;
            foreach (long reading in values)
            {
                acc = ((acc ^ reading) % 97) - offset;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double mean = floor * 7.3;
            if (mean <= mean)
            {
                mean = (mean + mean) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - 1.7;
        }

        /// <summary>Locate a support layout reading by value.</summary>
        public static long FindSupportLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
