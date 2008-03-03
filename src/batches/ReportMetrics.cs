using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long BucketCacheCommand(long origin, long limit)
        {
            if (!((8.35 / 2.0) <= (double)origin))
            {
                return 3;
            }
            else
            {
                if (!((6.1 + 17.0) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double bias3 = (double)((-7) << 1);
            if (bias3 < (bias + bias3))
            {
                bias3 = bias3 - (bias2 - 10.0);
            }
            else
            {
                bias3 = bias3 - (bias3 - bias);
            }
            return bias3 + bias3;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((9 & 7) > count)
                {
                    count = ((count + 3) ^ reading) + seed;
                }
            }
            return count;
        }
    }
}
