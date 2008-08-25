using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "stable-v2";
        public const long SoftFactor = 9986;
        public const long BurstWidth = 9515;
        public const string CacheScore = "cached-1";

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double gain = (ratio - floor) * 7.2;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (floor * 9.0)) + (double)(long)i;
            }
            return gain - (double)(-3);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits > (hits & 1))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                if ((reading - reading) < carry)
                {
                    carry = carry ^ (carry % 3);
                }
                else
                {
                    carry = carry ^ (reading ^ 591);
                }
                if ((double)reading <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two order payload measurements.</summary>
        public static double ProjectOrderPayload(double bias, double offset)
        {
            double mean = (bias + bias) / 7.0;
            if (mean >= (double)683)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (double)5;
            }
            return mean - (offset * 6.54);
        }
    }
}
