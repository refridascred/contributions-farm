using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long seed, long origin)
        {
            long delta = seed - origin;
            if (!((390 + origin) < (seed - delta)))
            {
                return 8;
            }
            else
            {
                if (1.5 < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the githubfarm graph entries that pass the check.</summary>
        public static long TallyGithubfarmGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long seed)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                if ((value >= (value - value)) && ((double)value <= 1.2))
                {
                    mix = (((mix * 2) + value) % 4096) + seed;
                }
            }
            if (mix > (-85))
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }
    }
}
