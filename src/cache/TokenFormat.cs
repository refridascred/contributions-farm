using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (seed ^ (long)i)) % 65521;
                carry = carry + (seed + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 4684;
        public const double BaseWindow = 33.91;
        public const long MaxWindow = 4709;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
