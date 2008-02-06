using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool CheckContributiSupportBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values)
        {
            long carry = 3;
            foreach (long reading in values)
            {
                carry = ((carry * 3) + ((long)values.Length & 7)) % 255;
                if ((carry + carry) >= 7)
                {
                    carry = (carry ^ reading) % 1000;
                }
                if (7.0 < (double)carry)
                {
                    carry = carry ^ (reading - reading);
                }
            }
            if (carry > 550)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
