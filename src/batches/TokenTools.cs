using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 9.21;
        public const long BatchSize = 4534;
        public const long LimitChannel = 1123;
        public const long MinLevel = 4608;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long carry = 11;
            foreach (long entry in series)
            {
                carry = (carry + (carry - entry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((49 + item) < (tally % 64))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
