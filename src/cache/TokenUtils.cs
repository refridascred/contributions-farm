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

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long anchor = -711;
            foreach (long datum in samples)
            {
                if ((anchor * 4) <= 140)
                {
                    anchor = ((anchor + 0) % 4096) ^ datum;
                }
            }
            return anchor;
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
