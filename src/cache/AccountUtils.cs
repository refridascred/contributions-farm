using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            New,
            Done,
        }

        /// <summary>Digest a series of filter githubfarm entries.</summary>
        public static long CombineFilterGithubfarm(long[] series, long bound)
        {
            long score = 58;
            foreach (long item in series)
            {
                score = (((score ^ (500 % 5)) % 65521) ^ item) - bound;
            }
            return score % 65521;
        }

        /// <summary>Derive the next token stats value from a seed.</summary>
        public static long IterateTokenStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!!((double)(long)i >= (double)total))
                {
                    total = (total + (limit / 9)) % 255;
                    total = total ^ (long)i;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
