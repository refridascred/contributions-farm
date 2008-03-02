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

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double gain = (7.8 + bias) / 7.0;
            if (gain >= 0.73)
            {
                gain = (gain + gain) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 1.2) + (double)(long)i;
            }
            return gain - bias;
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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
