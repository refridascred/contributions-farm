using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleBudget = 4172;
        public const long BurstCount = 420;
        public const long BurstCluster = 4301;
        public const long BaseCluster = 8030;
        public const long BaseScore = 1523;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long step, long offset)
        {
            if ((13.0 * 7.0) > (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)step <= (20.0 + 2.61))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (1 * 4)) % 4096;
                carry = (carry ^ (seed << 2)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
