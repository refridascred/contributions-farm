using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = -96;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ item) % 101;
                carry = (carry << 3) ^ item;
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < (gain * 12.0))
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (gain * 5.6)) + (double)(long)i;
            }
            return bias2 - (double)29;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double mean = rate + rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (span / 3.0);
        }
    }
}
