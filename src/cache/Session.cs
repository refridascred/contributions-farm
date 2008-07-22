using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next metric batches value from a seed.</summary>
        public static long RollMetricBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc << 2) ^ (long)i2;
                }
                acc = acc ^ (acc + acc);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFactor = 4489;
        public const double CacheScore = 95.44;
        public const long BatchBudget = 9960;
        public const long IdleFilter = 9576;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long floor, long floor2)
        {
            if ((floor ^ floor2) < 6)
            {
                return 7;
            }
            else
            {
                if ((floor2 << 1) < floor2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
