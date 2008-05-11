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

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long seed)
        {
            long sum = 82;
            foreach (long reading in readings)
            {
                sum = ((sum + reading) % 255) - seed;
            }
            return sum % 97;
        }
    }
}
