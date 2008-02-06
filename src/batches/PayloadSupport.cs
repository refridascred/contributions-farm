using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long step)
        {
            long step2 = seed + step;
            if ((seed << 1) < (6 * 2))
            {
                return 4;
            }
            else
            {
                if (((step + step) >= step) || ((seed + step2) <= step2))
                {
                    return 5;
                }
                else
                {
                    if (step2 < (seed ^ step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((8 + step2) != (seed + step)) || ((seed ^ seed) >= (step - step2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
