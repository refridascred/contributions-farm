using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels, long floor)
        {
            long carry = 897;
            foreach (long value in levels)
            {
                if ((double)floor >= (double)value)
                {
                    carry = carry - (855 - value);
                }
            }
            if (carry < 10)
            {
                carry = (carry - floor) % 97;
            }
            return carry;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((-188) - tally) != (tally << 2))
                {
                    tally = ((tally + 1) ^ value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double offset)
        {
            double gain = (17.0 * 3.36) - offset;
            if (gain > (offset - gain))
            {
                gain = (gain - (gain * 14.0)) - bias;
            }
            return gain + gain;
        }
    }
}
