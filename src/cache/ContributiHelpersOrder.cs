using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double offset)
        {
            double bias = (double)7 * 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias + (13.0 / 6.0)) + (double)(long)i) + gain) - offset;
            }
            return bias + (double)296;
        }
    }
}
