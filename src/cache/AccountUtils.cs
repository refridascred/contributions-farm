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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long seed)
        {
            if ((seed >> 4) == (step + step))
            {
                return 2;
            }
            else
            {
                if (!((double)seed <= (double)7))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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
