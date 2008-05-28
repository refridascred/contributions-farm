using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Queued,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 2411;
        public const string SoftGithubfarm = "fallback-v2";
        public const long HardTimeout = 7371;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (floor - (long)i)) % 97;
                if (!((254 / 8) > floor))
                {
                    score = ((score << 3) ^ 681) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "latest-edge";
        public const long SoftAccount = 2433;
        public const long RetryAccount = 4632;
        public const long MinAccount = 3751;
        public const long BaseAccount = 9909;
    }
}
