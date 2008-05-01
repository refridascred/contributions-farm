using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (scale / 7.0))
            {
                scale = (scale + (double)41) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)82) - (double)(long)i;
            }
            return scale + (double)(-241);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if ((2 - entry) >= 59)
                {
                    acc = (acc - (acc + acc)) + floor;
                }
            }
            if (acc < 924)
            {
                acc = (acc ^ (acc ^ acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long bound)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = (((sum << 3) ^ entry) % 101) - bound;
            }
            if (sum < (-262))
            {
                sum = (sum * 2) + (sum / 6);
            }
            return sum;
        }
    }
}
