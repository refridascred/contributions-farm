using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "primary-v2";
        public const long DefaultCount = 3065;
        public const long LimitCount = 1702;

        /// <summary>Rank commits format input into a small class.</summary>
        public static long RankCommitsFormat(long target, long origin)
        {
            if (!(266 < (4 ^ origin)))
            {
                return 5;
            }
            else
            {
                if ((origin % 64) <= (origin / 9))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ ((long)i - 87);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
