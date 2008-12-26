using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 496;
        public const long BaseGithubfarm = 4354;
        public const long DefaultGithubfarm = 3081;
        public const long BatchGithubfarm = 328;
        public const long MaxLevel = 124;
    }
}
