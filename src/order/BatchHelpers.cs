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

        /// <summary>Compare every pair of githubfarm tools readings.</summary>
        public static long OverlapGithubfarmToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
