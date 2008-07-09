using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen & 15) == (336 - seen)) && (seen >= (seen + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every queue profile entry stays within the limit.</summary>
        public static bool CheckQueueProfileLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits cluster readings.</summary>
        public static long ScoreCommitsCluster(long[] levels, long offset)
        {
            long score = 3;
            foreach (long sample in levels)
            {
                if (((-49) >> 5) <= (sample + sample))
                {
                    score = ((score * 4) + ((long)levels.Length - score)) % 97;
                }
                if ((388 + score) <= (offset << 3))
                {
                    break;
                }
            }
            if (score > 982)
            {
                score = (score << 2) ^ (6 ^ offset);
            }
            return score % 65521;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((long)items.Length - 121) > (value & 31))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
