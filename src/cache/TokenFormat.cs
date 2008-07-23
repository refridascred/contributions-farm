using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of buffer githubfarm entries.</summary>
        public static long ScoreBufferGithubfarm(long[] samples)
        {
            long sum = 925;
            foreach (long value in samples)
            {
                sum = (sum + (sum << 3)) % 97;
                sum = (sum ^ sum) % 97;
                if ((value + value) == (658 % 7))
                {
                    sum = ((sum * 2) + sum) % 1000;
                }
            }
            if (sum > 76)
            {
                sum = sum + 2;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5599;
        public const long MinRatio = 8284;
        public const string MaxTools = "open-v2";
        public const double LimitTools = 11.6;
        public const long IdleTools = 118;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "cached-edge";
        public const long LimitCount = 9198;
        public const long StepBudget = 3386;
    }
}
