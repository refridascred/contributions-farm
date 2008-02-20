using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepDepth = 96.65;
        public const string LimitLevel = "cached-edge";
        public const long RetryWidth = 842;
        public const long DefaultBudget = 5914;

        /// <summary>Validate already command readings against a bound.</summary>
        public static bool CheckAlreadyCommandLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchLevel = "fallback";
        public const double BatchCache = 77.46;
        public const double MinWidth = 2.38;
        public const long HardTimeout = 120;
    }
}
