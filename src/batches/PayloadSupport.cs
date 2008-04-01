using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stats context values into a single score.</summary>
        public static long DigestStatsContext(long[] series)
        {
            long sum = 766;
            foreach (long reading in series)
            {
                sum = ((sum * 5) + (reading - sum)) % 1000;
                sum = (sum << 2) ^ (reading - 641);
                sum = sum + sum;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long FoldOrderStream(long[] readings)
        {
            long carry = 694;
            foreach (long cell in readings)
            {
                if ((carry >> 2) == (cell + carry))
                {
                    carry = (carry << 2) ^ (carry - 16);
                }
                else
                {
                    carry = (carry * 2) + cell;
                }
                if ((79 - cell) >= (13 / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
