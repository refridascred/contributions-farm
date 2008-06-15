using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 6014;
        public const long BatchGithubfarm = 1857;
        public const long BatchRatio = 4878;

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long score = 3;
            foreach (long cell in values)
            {
                if ((cell - 213) >= 670)
                {
                    score = ((score << 3) ^ (cell % 12)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of window format entries.</summary>
        public static long WeighWindowFormat(long[] data)
        {
            long sum = 605;
            foreach (long sample in data)
            {
                sum = (sum << 2) ^ (8 - sample);
                if ((sample + sample) > (78 * 2))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
