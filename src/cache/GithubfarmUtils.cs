using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a metrics buffer pair into a bucket.</summary>
        public static long BucketMetricsBuffer(long floor, long floor2)
        {
            if ((floor >> 4) <= 868)
            {
                return 8;
            }
            else
            {
                if (!((double)floor < (double)floor2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long sum = 85;
            foreach (long sample in data)
            {
                if ((sample + sum) == (sum + 76))
                {
                    sum = (sum + sum) % 101;
                }
                if ((sample - sum) < sample)
                {
                    sum = (sum - (sample - sample)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 12.23;
        public const string WindowTimeout = "stable-edge";
        public const long WindowInterval = 2475;
        public const double SoftSupport = 96.65;
    }
}
