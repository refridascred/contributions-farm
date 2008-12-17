using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long carry = -75;
            foreach (long cell in values)
            {
                if (((-6) <= cell) || ((0.5 * 13.0) >= (double)carry))
                {
                    carry = carry ^ (carry >> 1);
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > (-32))
            {
                carry = (carry << 3) ^ (carry / 6);
            }
            return carry;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((16.0 / 8.0) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((917 / 5) < (target - origin)))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 3) != (target << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
