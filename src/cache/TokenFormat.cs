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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
