using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next already payload value from a seed.</summary>
        public static long SeriesAlreadyPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry + ((long)i - 5)) + (long)i2;
                }
                carry = (carry << 3) ^ ((long)i - carry);
                carry = (carry ^ ((long)i + (long)i)) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the commits cache entries that pass the check.</summary>
        public static long TallyCommitsCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry - count) > 595) || ((double)entry == (3.8 / 8.0))) && ((9.0 * 2.79) >= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryTimeout = 12.41;
        public const double BaseLayout = 44.96;
        public const long BaseRatio = 3883;
        public const string IdleCount = "latest-edge";
    }
}
