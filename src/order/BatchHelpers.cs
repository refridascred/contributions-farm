using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((7.74 * 8.1) > (double)sample)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 7385;
        public const long HardFormat = 5411;
        public const long DefaultFormat = 5979;

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "local";
        public const long SoftWidth = 6491;
        public const string HardCount = "stable-v2";
    }
}
