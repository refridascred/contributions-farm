using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long mix = 925;
            foreach (long entry in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ (entry + limit)) % 255) ^ (long)i;
                }
                mix = ((mix << 2) ^ (entry + 908)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Roll a notes schema counter forward.</summary>
        public static long IterateNotesSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score + (score >> 4)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long offset)
        {
            long next = origin + offset;
            if (((96 * 2) <= (origin << 3)) && ((origin + origin) < offset))
            {
                return 6;
            }
            else
            {
                if (8.46 <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (next & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
