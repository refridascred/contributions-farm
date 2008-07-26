using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long mark = 9;
            foreach (long value in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark + (676 - mark)) + (long)i;
                }
                mark = (mark + value) % 255;
                if (!((758 * 5) == ((long)samples.Length + value)))
                {
                    mark = mark + value;
                }
            }
            if (mark < 3)
            {
                mark = (mark - (mark >> 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
