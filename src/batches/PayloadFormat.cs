using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings, long offset)
        {
            long total = 25;
            foreach (long reading in readings)
            {
                if (((offset / 8) >= total) || ((2.7 + 16.0) > (double)reading))
                {
                    total = total + reading;
                }
            }
            return total;
        }

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
