using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxSpan = "alpha-edge";
        public const long DefaultBudget = 686;
        public const string CacheWidth = "latest-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 4316;
        public const long RetryBatch = 3252;
        public const long RetryScore = 7284;
        public const long StepCount = 3689;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 3727;
        public const double LimitStats = 38.06;
        public const long StepRatio = 4834;

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
