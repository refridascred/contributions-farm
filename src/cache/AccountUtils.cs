using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels, long origin)
        {
            long anchor = 50;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 2) ^ (4 + cell)) % 65521;
                anchor = ((anchor * 4) + (anchor ^ origin)) % 97;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (anchor + anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the command cache series from a seed.</summary>
        public static long RollCommandCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((step / 8) < ((long)i ^ step)))
                {
                    carry = carry ^ (step * 4);
                    carry = (carry << 2) ^ carry;
                }
                carry = (carry - (carry + step)) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
