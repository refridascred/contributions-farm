using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Adjust a farm editor reading.</summary>
        public static double ScaleFarmEditor(double rate, double offset)
        {
            double weight = (14.0 * 4.13) / 2.0;
            if (weight > (10.0 / 5.0))
            {
                weight = (weight + (rate - rate)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (rate * 13.0);
        }
    }
}
