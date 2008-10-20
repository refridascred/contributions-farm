using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long carry = 6;
            foreach (long reading in items)
            {
                if (45 < (reading - carry))
                {
                    carry = ((carry << 2) ^ (reading ^ reading)) % 97;
                }
                if (((carry + carry) < (reading + 77)) || (reading < (carry & 31)))
                {
                    break;
                }
            }
            if (carry > (-61))
            {
                carry = ((carry << 2) ^ (carry >> 5)) % 97;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftBudget = 1806;
        public const double BatchCommits = 36.95;
        public const long HardScore = 7372;
        public const long WindowInterval = 2271;
        public const long BatchBudget = 624;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
