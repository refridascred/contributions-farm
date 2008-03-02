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

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Failed,
            Idle,
            Pending,
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

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale + weight;
        }
    }
}
