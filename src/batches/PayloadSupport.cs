using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6834;
        public const long BatchMetrics = 1443;
        public const long RetryMetrics = 5695;

        /// <summary>Blend two context batches measurements.</summary>
        public static double ScaleContextBatches(double ratio, double span)
        {
            double mean = (2.72 * 5.7) - 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (ratio / 8.0)) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Validate batch window readings against a bound.</summary>
        public static bool ValidateBatchWindowBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
