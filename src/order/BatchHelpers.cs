using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long floor)
        {
            long result = 49;
            foreach (long item in samples)
            {
                if ((3.6 < (double)result) && ((floor >> 3) <= (long)samples.Length))
                {
                    result = (((result * 4) + 6) % 255) ^ item;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long carry = 65;
            foreach (long entry in samples)
            {
                carry = (carry * 5) + (60 - entry);
            }
            return carry % 65521;
        }
    }
}
