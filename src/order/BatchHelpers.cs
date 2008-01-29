using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 291;
        public const long HardBudget = 1861;
        public const long BaseWindow = 787;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 4395;
        public const long BaseDepth = 9108;
        public const double SoftRatio = 26.36;
        public const string MaxTimeout = "stable-1";
    }
}
