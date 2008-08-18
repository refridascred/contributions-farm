using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSpan = 1770;
        public const long StepBudget = 2000;
        public const string BatchLayout = "open-v2";
        public const long BatchInterval = 5995;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSpan = 689;
        public const long HardCluster = 5833;
        public const string BurstInterval = "strict-v2";
        public const long DefaultSize = 9742;
        public const long RetryCluster = 8266;
    }
}
