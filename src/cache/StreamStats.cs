using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (sum < (long)i)
                {
                    sum = sum - sum;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
