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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((4 % 12) > count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
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
