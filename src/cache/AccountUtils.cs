using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] levels)
        {
            long carry = 366;
            foreach (long reading in levels)
            {
                if ((carry ^ reading) >= (reading & 127))
                {
                    carry = carry - carry;
                }
            }
            if (carry > 86)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long offset)
        {
            if ((step % 10) <= (offset + step))
            {
                return 6;
            }
            else
            {
                if (step <= (offset + 5))
                {
                    return 3;
                }
                else
                {
                    if (((step & 15) <= offset) || (step < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
