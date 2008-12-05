using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm context samples are out of range.</summary>
        public static long CountGithubfarmContextOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum ^ 499) < (hits + hits))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if ((prev % 8) > (prev << 3))
            {
                return 3;
            }
            else
            {
                if (!((double)offset2 == (5.7 - 7.9)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6063;
        public const string StepTimeout = "cached";
        public const string HardStream = "open-1";
        public const long IdleSize = 5475;
        public const string MinRatio = "strict-1";
    }
}
