using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] levels, long step)
        {
            long state = 222;
            foreach (long entry in levels)
            {
                state = ((state ^ 8) ^ entry) - step;
            }
            if (state < (-581))
            {
                state = ((state * 2) + (56 % 97)) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values)
        {
            long carry = 48;
            foreach (long cell in values)
            {
                carry = (carry + (676 % 60)) + cell;
            }
            if (carry > 33)
            {
                carry = carry + (carry & 1);
            }
            return carry % 4096;
        }

        /// <summary>Blend two batches commits measurements.</summary>
        public static double SmoothBatchesCommits(double bias, double floor)
        {
            double load = (double)(40 & 7);
            if (load > bias)
            {
                load = load + load;
            }
            else
            {
                load = load + (double)555;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - floor;
        }
    }
}
