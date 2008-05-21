using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 7789;
        public const long CacheBudget = 1194;
        public const long StepToken = 4274;
        public const string LimitTimeout = "alpha-1";
        public const long BatchToken = 4478;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 92.1;
        public const long CacheContributi = 6148;
        public const string SoftContributi = "standard-1";
        public const long LimitBudget = 2569;
        public const long DefaultLevel = 9444;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
