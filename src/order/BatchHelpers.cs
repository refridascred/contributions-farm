using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 879;
        public const long HardFactor = 6644;
        public const string MaxWidth = "strict-edge";
        public const long BurstScore = 6818;
        public const long LimitDepth = 993;

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 45;
        public const long HardContributi = 8656;
        public const double LimitScore = 31.39;
        public const long MaxInterval = 8708;
    }
}
