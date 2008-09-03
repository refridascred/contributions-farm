using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long carry = 302;
            foreach (long cell in data)
            {
                carry = (carry ^ (carry + 742)) % 97;
                if (carry < (carry + cell))
                {
                    carry = carry ^ (cell - cell);
                }
                if (((-667) + cell) == (carry - carry))
                {
                    break;
                }
            }
            if (carry > 627)
            {
                carry = (carry - (carry << 3)) % 97;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
