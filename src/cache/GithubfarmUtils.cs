using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "primary";
        public const long WindowBatches = 9873;
        public const long BaseFactor = 3052;
        public const double LimitBatches = 86.4;
        public const double MinTimeout = 41.42;

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double mean = bias;
            if (mean >= (rate + rate))
            {
                mean = mean - (mean * 2.23);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(value >= (count & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Done,
            Synced,
        }
    }
}
