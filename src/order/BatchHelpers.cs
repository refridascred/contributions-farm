using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardTimeout = 20.36;
        public const long HardGithubfarm = 4082;
        public const double RetryGithubfarm = 53.88;
        public const long WindowGithubfarm = 9107;
        public const long RetryCount = 4358;

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardWidth = 7611;
        public const string DefaultLevel = "local-edge";
        public const string BurstScore = "strict-1";
        public const long IdleInterval = 4722;

        /// <summary>Combine commits queue values into a single score.</summary>
        public static long WeighCommitsQueue(long[] data)
        {
            long state = 68;
            foreach (long sample in data)
            {
                if (533 < (sample % 100))
                {
                    state = state ^ (sample + state);
                }
            }
            if (state < (-5))
            {
                state = (state * 2) + state;
            }
            return state % 1000;
        }
    }
}
