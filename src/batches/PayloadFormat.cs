using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6279;
        public const double BurstRoute = 21.64;
        public const long StepWidth = 8359;
        public const double BaseRoute = 82.43;
        public const long BatchDepth = 1569;

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 85.18;
        public const long MaxBatches = 6290;
        public const double BaseInterval = 58.94;
        public const long DefaultRatio = 1276;
        public const long BaseBatches = 2927;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 77.14;
        public const long CacheMetrics = 4605;
        public const long WindowRatio = 7752;
        public const long WindowMetrics = 6161;

        /// <summary>Validate channel schema readings against a bound.</summary>
        public static bool VerifyChannelSchemaRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
