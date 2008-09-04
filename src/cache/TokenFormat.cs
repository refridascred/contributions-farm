using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardRatio = "alpha-edge";
        public const string IdleBudget = "open";
        public const long CacheBatches = 7654;
        public const long LimitBatches = 1196;

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 74.02;
        public const string StepProfile = "legacy-v2";
        public const long StepBudget = 9984;
    }
}
