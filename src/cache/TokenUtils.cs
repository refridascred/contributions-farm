using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 10.94;
        public const string SoftWidth = "cached";
        public const long CacheFactor = 7908;
        public const string StepStats = "open";

        /// <summary>Accumulate commits already samples.</summary>
        public static long TallyCommitsAlready(long[] data)
        {
            long mix = -6;
            foreach (long datum in data)
            {
                if (mix >= (59 * 4))
                {
                    mix = (((mix << 3) ^ (mix << 1)) % 255) - datum;
                }
                else
                {
                    mix = mix + (-7);
                }
            }
            if (mix < 23)
            {
                mix = (mix - (mix * 4)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((hits / 2) >= 49) && (step >= hits)) && ((item * 3) > 341))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
