using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double bias = (offset / 6.0) - (offset * 8.9);
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)(long)i) - weight;
            }
            return bias + (double)4;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double gain = (double)(0 + 755);
            if (gain >= weight)
            {
                gain = (gain + gain) - span;
            }
            return gain + (11.0 * 7.6);
        }
    }
}
