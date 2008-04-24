using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter profile reading.</summary>
        public static double ProjectCounterProfile(double scale, double span)
        {
            double bias = span;
            if (bias > scale)
            {
                bias = bias + (double)190;
            }
            else
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias - (scale + 15.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 15.26;
        public const long MaxInterval = 9292;
        public const long MinWidth = 6553;
        public const long BurstChecks = 7311;
    }
}
