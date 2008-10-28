using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a schema route value against two limits.</summary>
        public static long BucketSchemaRoute(long offset, long limit)
        {
            if ((0.3 - 4.75) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if (((offset + offset) < (11 - 5)) || ((offset / 7) < (limit ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((9.23 * 13.0) > (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (sum >> 4);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + 4) != (7 & 31))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }
    }
}
