using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = 18.0;
            return ((load - (double)7) + bias) + floor;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (double)897) + (double)(long)i) - floor;
            }
            return mean + (scale / 3.0);
        }
    }
}
