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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
