using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string StepWidth = "alpha";
        public const long IdleStats = 6254;
        public const string MinStats = "staging-v2";
        public const long BaseStats = 947;
        public const long DefaultStats = 5312;

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 7151;
        public const double CacheSupport = 94.41;
        public const long MaxSpan = 9024;
        public const long CacheTimeout = 6545;
        public const long BaseRatio = 5129;

        /// <summary>Measure how many layout stats samples are out of range.</summary>
        public static long AuditLayoutStatsMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (double)9)
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
