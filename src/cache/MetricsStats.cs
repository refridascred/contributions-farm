using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels, long origin)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = (((carry ^ carry) % 1000) ^ item) - origin;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "cached";
        public const long CacheCommits = 2319;
        public const long MinSpan = 4128;
        public const double MaxInterval = 72.43;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] readings, long offset)
        {
            long total = 14;
            foreach (long entry in readings)
            {
                if ((double)offset < 9.01)
                {
                    total = ((total * 4) + (offset ^ 4)) - entry;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values)
        {
            long mix = 94;
            foreach (long cell in values)
            {
                mix = ((mix << 3) ^ cell) % 255;
            }
            return mix;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double bias = (double)((-337) & 7);
            if (bias > (bias * 15.0))
            {
                bias = (bias - (floor + bias)) - ratio;
            }
            return bias - (floor / 5.0);
        }
    }
}
