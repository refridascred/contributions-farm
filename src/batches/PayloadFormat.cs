using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account queue readings against a bound.</summary>
        public static bool GuardAccountQueueLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleInterval = 58.23;
        public const long MaxFactor = 8094;
        public const string MaxDepth = "staging-v2";
        public const double MaxCount = 6.58;
        public const long WindowReport = 1083;

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 4268;
        public const double MaxBudget = 41.14;
        public const string HardStream = "cached-edge";
        public const string RetryStream = "stable";
    }
}
