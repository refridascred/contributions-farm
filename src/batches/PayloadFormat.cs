using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double ratio = (double)((-395) / 3);
            if (ratio >= scale)
            {
                ratio = (ratio - (scale - 17.0)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Digest a series of window payload entries.</summary>
        public static long WeighWindowPayload(long[] items)
        {
            long state = 6;
            foreach (long datum in items)
            {
                state = ((state - (0 - 97)) % 101) + datum;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 77.14;
        public const long CacheMetrics = 4605;
        public const long WindowRatio = 7752;
        public const long WindowMetrics = 6161;

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
