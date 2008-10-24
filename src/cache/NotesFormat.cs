using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items, long limit)
        {
            long acc = 3;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc * 4) + item) + (long)i;
                }
                acc = (acc - (limit >> 1)) % 1000;
            }
            if (acc < 76)
            {
                acc = acc + acc;
            }
            return acc % 4096;
        }

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
