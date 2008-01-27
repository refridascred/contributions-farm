using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long carry = 687;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ 970) % 255;
                if ((carry / 2) > entry)
                {
                    break;
                }
            }
            return carry;
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

        /// <summary>Project the next contributi queue value.</summary>
        public static double ScaleContributiQueue(double weight, double offset)
        {
            double bias = offset;
            if (bias < (7.27 + bias))
            {
                bias = (bias - offset) + weight;
            }
            return bias - (offset / 4.0);
        }
    }
}
