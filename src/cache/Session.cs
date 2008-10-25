using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + origin) % 1000;
                if (((double)sum < (double)71) && ((0 + (long)i) == (sum ^ sum)))
                {
                    sum = sum - 514;
                    sum = (sum * 3) + (27 - origin);
                }
                else
                {
                    sum = (sum ^ ((long)i + origin)) % 4096;
                    sum = (sum + (230 - (long)i)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Retry,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 2253;
        public const long BatchGithubfarm = 2795;
        public const string MinGithubfarm = "staging";
        public const long RetryCount = 4669;

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheFactor = "fallback-edge";
        public const double BurstLayout = 69.47;
        public const long StepScore = 6935;
        public const long BaseSize = 1529;
        public const double BatchDepth = 44.3;
    }
}
