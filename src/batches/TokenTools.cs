using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = -96;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ item) % 101;
                carry = (carry << 3) ^ item;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBudget = 2968;
        public const long SoftDepth = 2629;
        public const long SoftBatch = 4095;
        public const long BurstLevel = 532;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
