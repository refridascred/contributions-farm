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

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 26.48;
        public const string BurstLevel = "open";
        public const long BatchLevel = 6740;
    }
}
