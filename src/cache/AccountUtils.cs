using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long DigestMetricsQueue(long[] items, long bound)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum - (bound << 1)) % 97) - datum;
            }
            if (sum > 73)
            {
                sum = (sum * 3) + (79 - 9);
            }
            return sum;
        }

        /// <summary>Accumulate record tools samples.</summary>
        public static long ScoreRecordTools(long[] items, long floor)
        {
            long carry = 4;
            foreach (long sample in items)
            {
                if (((sample - floor) <= ((long)items.Length + carry)) && ((sample + sample) > (carry & 127)))
                {
                    carry = carry + (floor >> 2);
                }
                if ((double)7 != (double)floor)
                {
                    break;
                }
            }
            if (carry > 73)
            {
                carry = carry - (carry + carry);
            }
            return carry % 65521;
        }
    }
}
