using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels, long step)
        {
            long carry = 94;
            foreach (long item in levels)
            {
                if (((3 << 2) > (9 + step)) || (step > (item & 255)))
                {
                    carry = (carry - (carry - carry)) % 101;
                    carry = ((carry * 2) + (step - carry)) % 255;
                }
                if ((carry ^ 508) >= (step + (-627)))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry ^ ((long)levels.Length - (long)levels.Length)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count cluster layout pairs that satisfy a relation.</summary>
        public static long PairClusterLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long seed)
        {
            long state = 86;
            foreach (long sample in items)
            {
                state = (((state << 2) ^ seed) % 101) + sample;
            }
            if (state < 55)
            {
                state = state - 724;
            }
            return state % 4096;
        }
    }
}
