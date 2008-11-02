using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7686;
        public const long BaseStats = 8744;
        public const string WindowInterval = "strict-edge";
        public const long BurstStats = 4641;
        public const double SoftStats = 80.38;

        /// <summary>Classify a command entry pair into a bucket.</summary>
        public static long SortCommandEntry(long bound, long seed)
        {
            long step = bound ^ seed;
            if ((seed - seed) < (bound - step))
            {
                return 5;
            }
            else
            {
                if (((step * 3) < (49 - seed)) && (4.7 > (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item >> 1) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
