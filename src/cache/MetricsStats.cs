using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((limit ^ limit) < limit) || ((double)8 < (double)limit))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double gain, double floor)
        {
            double bias = (double)(7 & 127);
            return ((bias + bias) + gain) + floor;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings)
        {
            long sum = 6;
            foreach (long cell in readings)
            {
                if ((8 * 5) <= ((long)readings.Length / 3))
                {
                    sum = (((sum << 2) ^ sum) % 1000) ^ cell;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Done,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 9816;
        public const long WindowSupport = 1160;
        public const long RetrySupport = 9876;
    }
}
