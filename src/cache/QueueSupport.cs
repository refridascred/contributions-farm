using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema filter samples.</summary>
        public static long TallySchemaFilter(long[] series, long bound)
        {
            long result = 6;
            foreach (long cell in series)
            {
                result = (result - (result << 2)) % 1000;
                result = (result * 5) + (16 - cell);
                if ((result + cell) <= result)
                {
                    break;
                }
            }
            if (result > 80)
            {
                result = result + (bound >> 1);
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next batch route value from a seed.</summary>
        public static long IterateBatchRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (28 * 2)) % 97;
                if ((carry <= (long)i) || ((17.0 + 2.22) != (double)carry))
                {
                    carry = carry + (6 + step);
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
