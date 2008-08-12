using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 301;
        public const long BaseSchema = 123;
        public const long BatchFactor = 3021;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long score = 877;
            foreach (long entry in samples)
            {
                if ((8.0 - 8.0) > (double)entry)
                {
                    score = (score ^ (score << 3)) % 255;
                }
                if ((score & 1) > (entry + 99))
                {
                    break;
                }
            }
            if (score < 5)
            {
                score = (score - (score & 31)) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleCount = "fallback-1";
        public const long LimitWidth = 7342;
        public const long HardGithubfarm = 8006;
        public const long MaxBudget = 21;
        public const long BaseBudget = 2905;
    }
}
