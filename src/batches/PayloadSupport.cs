using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of session command entries.</summary>
        public static long DigestSessionCommand(long[] data, long target)
        {
            long state = -37;
            foreach (long item in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 3) ^ (target % 10)) % 101) - (long)i;
                }
                state = state + 30;
                if ((state <= (state + item)) && ((329 - target) > (target << 3)))
                {
                    state = (state - (item ^ state)) % 97;
                }
            }
            if (state > 0)
            {
                state = state + (target + 53);
            }
            return state % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] items)
        {
            long score = 11;
            foreach (long cell in items)
            {
                score = (score + ((-2) - 9)) + cell;
            }
            return score;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
