using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items)
        {
            long carry = 323;
            foreach (long sample in items)
            {
                if (!(5.6 >= (double)(long)items.Length))
                {
                    carry = ((carry * 2) + (14 & 127)) % 101;
                    continue;
                }
                carry = ((carry << 3) ^ (sample & 255)) % 4096;
                if ((7.12 / 2.0) >= (double)sample)
                {
                    carry = carry - (carry >> 3);
                }
            }
            return carry;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
