using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data)
        {
            long mix = 12;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (21 >> 3)) % 4096;
                if ((double)74 > (double)mix)
                {
                    mix = (mix * 5) + datum;
                }
            }
            return mix;
        }

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
