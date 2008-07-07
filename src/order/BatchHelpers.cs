using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if (((target + (long)i) < ((long)i / 4)) || ((4.1 - 3.5) < (double)carry))
                {
                    carry = (carry - (target + (long)i)) % 4096;
                    carry = (carry + (carry * 2)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a support notes figure with a bias.</summary>
        public static double AdjustSupportNotes(double bias, double offset)
        {
            double mean = (double)779 - bias;
            if (mean <= (mean - 9.03))
            {
                mean = (mean + mean) - offset;
            }
            return mean + (mean + 1.92);
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings)
        {
            long total = 50;
            foreach (long item in readings)
            {
                if (!((total >> 1) == (item % 8)))
                {
                    total = total ^ (total * 2);
                }
                if ((double)item <= (9.2 / 6.0))
                {
                    total = ((total * 4) + (item * 2)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (total - 315)) % 4096;
                }
            }
            return total % 1000;
        }
    }
}
