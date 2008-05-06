using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up contributi buffer samples.</summary>
        public static long PairContributiBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitLevel = 85.86;
        public const string RetryMetric = "fallback-edge";
        public const long MinMetric = 3897;
        public const long SoftCount = 8555;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseDepth = 3095;
        public const string HardScore = "staging";
        public const long CacheLevel = 3143;
        public const string LimitContributi = "alpha-1";
    }
}
