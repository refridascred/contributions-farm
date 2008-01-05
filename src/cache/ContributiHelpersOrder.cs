using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double bias2 = bias / 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (floor / 6.0);
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long limit)
        {
            if (831 >= (limit >> 5))
            {
                return 0;
            }
            else
            {
                if (((4.6 * 9.3) != (double)target) || ((target ^ limit) <= (target % 8)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
