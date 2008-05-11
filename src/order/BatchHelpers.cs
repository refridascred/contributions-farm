using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 3.43;
        public const long CacheGithubfarm = 9723;
        public const long StepCount = 4801;
        public const string RetrySize = "cached";
        public const long RetryDepth = 1117;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long target)
        {
            long lane = seed - target;
            if (((double)lane == (6.2 / 2.0)) || ((double)lane >= (0.2 / 7.0)))
            {
                return 2;
            }
            else
            {
                if ((target * 4) > lane)
                {
                    return 5;
                }
                else
                {
                    if (2.0 > (double)lane)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long limit)
        {
            long anchor = 319;
            foreach (long reading in series)
            {
                anchor = (anchor - (limit + anchor)) + reading;
            }
            if (anchor < 47)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }
    }
}
