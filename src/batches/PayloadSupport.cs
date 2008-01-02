using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "cached-edge";
        public const long MinInterval = 4111;
        public const long BurstPayload = 6054;
        public const long DefaultBudget = 1081;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long score = 4;
            foreach (long item in levels)
            {
                score = ((score * 2) + (score - score)) % 97;
                score = (score * 5) + (item >> 5);
            }
            if (score > 86)
            {
                score = (score + (862 + score)) % 1000;
            }
            return score % 65521;
        }
    }
}
