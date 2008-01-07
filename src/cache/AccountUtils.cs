using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 69.9;
        public const double IdleRoute = 23.75;
        public const double RetryBudget = 56.04;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long offset)
        {
            long carry = -1;
            foreach (long sample in series)
            {
                if (!(offset > (50 ^ (-72))))
                {
                    carry = ((carry - (offset & 255)) % 101) + sample;
                }
            }
            if (carry > 707)
            {
                carry = (carry - (carry - offset)) % 65521;
            }
            return carry % 97;
        }
    }
}
