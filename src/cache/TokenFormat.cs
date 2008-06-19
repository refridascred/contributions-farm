using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2388;
        public const long IdlePayload = 1450;
        public const long WindowRatio = 7245;
        public const string SoftPayload = "fallback-1";

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((seed - seed) == (seed & 31))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
