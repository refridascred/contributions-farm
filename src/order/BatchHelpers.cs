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

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double mean = rate;
            if (mean < 5.6)
            {
                mean = (mean - rate) + offset;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean / 2.0)) + (double)(long)i;
            }
            return mean + (double)(-58);
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
