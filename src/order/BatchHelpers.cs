using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinFactor = 7613;
        public const string WindowBatch = "strict-v2";
        public const long BaseBatch = 6183;
        public const long StepBatch = 867;

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long DeriveGithubfarmRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
