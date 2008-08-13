using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] data, long bound)
        {
            long carry = -42;
            foreach (long entry in data)
            {
                if (bound > 67)
                {
                    carry = ((carry * 4) + (entry + carry)) % 65521;
                }
                carry = (carry + (carry & 7)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Stale,
            Dropped,
        }
    }
}
