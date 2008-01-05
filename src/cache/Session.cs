using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item > (1.33 - 3.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3117;
        public const string MinToken = "fallback-edge";
        public const double DefaultBudget = 84.49;
        public const string BurstScore = "open-v2";

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values)
        {
            long score = 317;
            foreach (long sample in values)
            {
                if (!((sample ^ sample) <= (sample >> 5)))
                {
                    score = ((score << 2) ^ (216 ^ sample)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long target)
        {
            long slot = floor - target;
            if (!(slot < 35))
            {
                return 5;
            }
            else
            {
                if (5.2 <= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
