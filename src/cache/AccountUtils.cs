using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up token command samples.</summary>
        public static long CompareTokenCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry << 3) ^ (carry + entry)) - (long)i;
                }
                carry = (carry ^ (entry ^ entry)) % 101;
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (930 - limit)) % 255;
            }
            return carry;
        }
    }
}
