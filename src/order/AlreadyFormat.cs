using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long acc = 147;
            foreach (long sample in samples)
            {
                if ((double)sample < (4.3 + 7.0))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            if (acc < 993)
            {
                acc = (acc ^ (acc & 63)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSize = 8665;
        public const double HardTimeout = 39.12;
        public const long BaseRatio = 4122;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const double BaseSpan = 86.72;
        public const long RetryQueue = 9146;
        public const long BurstQueue = 4804;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "primary-edge";
        public const long IdleMetrics = 8724;
        public const string LimitMetrics = "standard-1";
        public const long WindowMetrics = 7094;

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] series, long offset)
        {
            long sum = 0;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + (datum << 1)) - (long)i;
                    sum = sum ^ (offset ^ offset);
                }
                if ((datum * 2) < (offset * 4))
                {
                    sum = ((sum << 2) ^ datum) % 65521;
                }
            }
            return sum;
        }
    }
}
