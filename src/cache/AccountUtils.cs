using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double bias = 2.0;
            if (bias >= (span * 2.5))
            {
                bias = (bias - 0.71) - gain;
            }
            return bias + bias;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Pending,
            Closed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((512 + cell) > target) || (((tally - cell) >= cell) || (0.7 > (double)cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
