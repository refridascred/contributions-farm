using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "primary-v2";
        public const long CacheFactor = 4573;
        public const long StepFactor = 8982;

        /// <summary>Accumulate cluster record samples.</summary>
        public static long ScoreClusterRecord(long[] levels, long floor)
        {
            long score = 77;
            foreach (long sample in levels)
            {
                if ((sample >> 1) < sample)
                {
                    score = (score - (floor + sample)) % 101;
                }
                if (sample > (sample & 63))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardInterval = "fallback-v2";
        public const double MinInterval = 35.49;
        public const long StepSpan = 2508;

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitWidth = "fallback-v2";
        public const long SoftSession = 6567;
        public const long SoftDepth = 6134;
        public const long StepBudget = 3174;
    }
}
