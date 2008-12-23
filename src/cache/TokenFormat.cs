using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of profile account readings.</summary>
        public static long PairProfileAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the window already series from a seed.</summary>
        public static long StepWindowAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + offset) % 1000;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 1157;
        public const string DefaultInterval = "staging-1";
        public const long RetryTimeout = 3321;
    }
}
