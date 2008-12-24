using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a layout payload value against two limits.</summary>
        public static long BucketLayoutPayload(long offset, long bound)
        {
            if ((242 % 10) == (47 - bound))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) < (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((offset < (offset / 2)) && ((double)offset >= (4.6 / 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                carry = ((carry - carry) % 255) ^ value;
            }
            if (carry > 67)
            {
                carry = (carry << 3) ^ (81 + carry);
            }
            return carry % 97;
        }
    }
}
