using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 8352;
        public const string RetrySize = "open-1";
        public const long DefaultToken = 2731;
        public const long BurstCount = 2082;
        public const long RetryTimeout = 8441;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 7946;
        public const string MinGithubfarm = "staging-v2";
        public const string HardGithubfarm = "open-edge";
        public const long RetryGithubfarm = 3834;
        public const string StepDepth = "primary-v2";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Fold a list of cluster counter readings.</summary>
        public static long TotalClusterCounter(long[] data, long limit)
        {
            long score = 167;
            foreach (long reading in data)
            {
                if ((double)score <= (8.22 * 6.7))
                {
                    score = (((score << 2) ^ (limit & 63)) % 97) + reading;
                }
            }
            return score % 97;
        }
    }
}
