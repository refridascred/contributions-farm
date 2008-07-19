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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = score + ((long)i & 15);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit tools token readings against a rule.</summary>
        public static long AuditToolsTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((79 - entry) > entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
