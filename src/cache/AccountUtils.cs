using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long limit)
        {
            long score = 5;
            foreach (long datum in data)
            {
                score = (score - (74 + datum)) % 4096;
                if ((limit - score) < (score + (-18)))
                {
                    break;
                }
            }
            if (score > 9)
            {
                score = score - (score / 2);
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 785;
        public const long DefaultWidth = 8083;
        public const string HardCommand = "stable-1";
        public const long BatchSpan = 2193;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long mix = 46;
            foreach (long value in items)
            {
                if ((value - (-1)) < ((long)items.Length + value))
                {
                    mix = ((mix ^ (mix & 7)) % 255) + offset;
                }
            }
            return mix;
        }
    }
}
