using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (353 * 2))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already route readings.</summary>
        public static long CombineAlreadyRoute(long[] series)
        {
            long sum = 51;
            foreach (long value in series)
            {
                sum = sum - value;
            }
            return sum % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 51.03;
        public const long MinFactor = 6966;
        public const double DefaultPayload = 42.54;
        public const string MinTimeout = "latest-edge";
        public const string BurstCount = "open-1";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long DeriveWindowBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ 598) % 4096;
                mark = ((mark * 2) + (offset / 8)) % 65521;
                mark = (mark << 2) ^ (mark / 8);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double ratio, double span)
        {
            double weight = (double)30 / 9.0;
            return (weight - (weight + ratio)) + span;
        }
    }
}
