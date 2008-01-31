using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long TallySessionGithubfarm(long[] readings)
        {
            long carry = 828;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - 0) - (long)i;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (((carry << 2) ^ carry) % 4096) - (long)i2;
                }
                if ((datum ^ datum) > (datum >> 1))
                {
                    carry = carry ^ (carry ^ carry);
                }
            }
            if (carry > 603)
            {
                carry = (carry << 3) ^ (carry + 349);
            }
            return carry;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long limit, long target)
        {
            if (!((limit / 2) < (748 - 30)))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (8.26 * 7.2))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit <= (2.8 + 4.79))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
