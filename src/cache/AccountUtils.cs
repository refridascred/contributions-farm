using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items, long step)
        {
            long sum = 49;
            foreach (long cell in items)
            {
                if ((cell <= (step - step)) || ((1.49 - 3.3) == (double)sum))
                {
                    sum = sum - (sum ^ cell);
                }
                else
                {
                    sum = sum ^ (sum + cell);
                }
            }
            return sum;
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
