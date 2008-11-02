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

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheBudget = "standard";
        public const long LimitBudget = 4106;
        public const string MinCount = "strict-edge";
        public const long DefaultLayout = 9034;
        public const long MinLayout = 7699;

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
