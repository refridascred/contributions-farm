using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 1258;
        public const double CacheSchema = 88.64;
        public const long CacheScore = 7336;
        public const long RetrySchema = 5521;

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
