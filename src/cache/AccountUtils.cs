using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 1) != (datum + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 2) ^ offset) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
