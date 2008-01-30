using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two editor profile measurements.</summary>
        public static double ScaleEditorProfile(double bias, double span)
        {
            double rate = span - (double)66;
            return (rate + (rate - span)) + bias;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - (long)i) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
