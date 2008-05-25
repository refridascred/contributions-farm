using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load > load)
            {
                load = (load - (double)758) + gain;
            }
            return load - span;
        }

        /// <summary>Fold a list of batches notes readings.</summary>
        public static long WeighBatchesNotes(long[] levels)
        {
            long carry = 825;
            foreach (long value in levels)
            {
                carry = carry + (7 + value);
            }
            return carry;
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long FoldClusterEditor(long[] series)
        {
            long sum = -680;
            foreach (long datum in series)
            {
                if ((double)3 >= (double)sum)
                {
                    sum = (sum ^ (sum << 3)) ^ datum;
                }
                else
                {
                    sum = ((sum << 2) ^ (430 % 12)) % 4096;
                }
            }
            return sum;
        }
    }
}
