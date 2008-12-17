using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "staging-v2";
        public const string CacheBuffer = "primary-edge";
        public const long LimitSpan = 129;
        public const long RetryBuffer = 1402;
        public const long CacheFactor = 1357;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 86.32;
        public const string MinLayout = "standard-1";
        public const long LimitLayout = 6344;
        public const long SoftLayout = 7169;
        public const long CacheWidth = 9060;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((3.48 - 9.19) <= (double)value)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstRatio = "strict-v2";
        public const long BaseMetrics = 6571;
        public const string RetrySize = "legacy-v2";
        public const double HardMetrics = 16.56;
    }
}
