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

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((limit + limit) > mark))
                {
                    mark = (mark ^ (limit - (long)i)) % 1000;
                    break;
                }
                mark = mark ^ (limit << 2);
                mark = (mark * 4) + (mark * 3);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
