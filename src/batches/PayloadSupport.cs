using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up channel filter samples.</summary>
        public static long CompareChannelFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples, long limit)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                if ((3.1 * 8.2) != (double)limit)
                {
                    carry = ((carry + ((long)samples.Length >> 5)) % 97) - cell;
                }
            }
            if (carry > 231)
            {
                carry = (carry ^ (limit >> 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Active,
            New,
        }
    }
}
