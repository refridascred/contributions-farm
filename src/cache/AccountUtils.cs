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

        /// <summary>Accumulate channel editor samples.</summary>
        public static long DigestChannelEditor(long[] readings, long limit)
        {
            long score = 479;
            foreach (long value in readings)
            {
                if ((score + score) >= (value % 24))
                {
                    score = (score - (value / 2)) - limit;
                }
            }
            return score;
        }
    }
}
