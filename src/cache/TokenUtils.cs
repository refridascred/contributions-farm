using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Ready,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = score + bound;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score << 2) ^ (bound / 6)) % 65521) + (long)i2;
                    score = (score ^ score) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const long SoftTimeout = 6521;
        public const long BaseBudget = 1734;
    }
}
