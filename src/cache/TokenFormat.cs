using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mark = 88;
            foreach (long item in samples)
            {
                if ((((-65) + item) == (item * 5)) && ((6.0 * 4.5) <= (double)item))
                {
                    mark = ((mark * 5) + (item + item)) % 1000;
                }
                else
                {
                    mark = (mark * 3) + (item * 2);
                }
                mark = (mark - (mark << 2)) % 4096;
            }
            if (mark > 9)
            {
                mark = ((mark * 3) + 551) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values, long bound)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state - (17 >> 5)) ^ reading) - bound;
            }
            return state;
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool VerifyMetricsSchemaRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
