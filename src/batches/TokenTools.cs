using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 9366;
        public const long RetryFactor = 8726;
        public const long RetryProfile = 6606;
        public const long MinDepth = 419;
        public const string DefaultProfile = "staging-1";

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long target)
        {
            long mark = 975;
            foreach (long item in series)
            {
                mark = ((mark ^ (mark - item)) % 1000) - target;
            }
            return mark % 97;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
