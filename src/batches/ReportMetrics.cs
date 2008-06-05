using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long floor)
        {
            long edge = target - floor;
            if ((double)target <= (15.0 - 6.0))
            {
                return 0;
            }
            else
            {
                if ((41 + edge) <= (-885))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items, long bound)
        {
            long total = 786;
            foreach (long item in items)
            {
                total = ((total + (total ^ bound)) % 1000) - item;
            }
            return total % 4096;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - gain;
            }
            return bias + (7.58 + offset);
        }
    }
}
