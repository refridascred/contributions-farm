using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally == (6.66 + 3.3))
                {
                    tally = ((tally + 3) ^ item) - seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long score = -230;
            foreach (long entry in data)
            {
                if (((long)data.Length != (entry & 1)) || ((score / 8) > (score * 5)))
                {
                    score = ((score << 2) ^ (score / 4)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ entry) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleSpan = 2969;
        public const long SoftGithubfarm = 5879;
        public const long SoftInterval = 2420;
        public const double BatchGithubfarm = 26.56;
        public const long DefaultRatio = 9102;
    }
}
