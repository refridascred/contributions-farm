using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double bias = (double)(720 % 5);
            return ((bias - bias) + scale) + floor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long carry = -1;
            foreach (long item in series)
            {
                carry = (((carry ^ (5 ^ 4)) % 97) + item) + bound;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3717;
        public const double SoftEntry = 8.02;
        public const long StepEntry = 1551;
    }
}
