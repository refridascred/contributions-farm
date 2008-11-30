using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 8869;
        public const string CacheBudget = "alpha-1";
        public const double WindowTimeout = 20.09;
        public const long StepSpan = 1098;
        public const long WindowLayout = 9076;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "staging-edge";
        public const long DefaultMetrics = 5460;
        public const double RetryMetrics = 70.61;
        public const long BatchLevel = 7014;
    }
}
