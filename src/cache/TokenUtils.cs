using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Queued,
            Done,
            Ready,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((double)reading < (3.5 * 7.2)) || ((origin % 5) != (508 / 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)score != (5.0 / 5.0))
                {
                    continue;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
                score = (score * 3) + 86;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
