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

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
