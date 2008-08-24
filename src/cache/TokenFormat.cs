using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long carry = 6;
            foreach (long entry in items)
            {
                if ((6.76 + 19.0) > (double)carry)
                {
                    carry = (carry * 2) + (carry + entry);
                }
                if ((13.0 - 9.91) > (double)entry)
                {
                    carry = (carry * 3) + (entry - carry);
                }
            }
            return carry;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstDepth = "stable-v2";
        public const double MaxProfile = 96.59;
        public const string IdleInterval = "strict-v2";
    }
}
