using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next profile githubfarm value from a seed.</summary>
        public static long IterateProfileGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + ((long)i >> 1)) % 4096;
                if (((long)i << 2) > acc)
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 5) + 10) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings)
        {
            long mark = 375;
            foreach (long cell in readings)
            {
                if (mark < (cell * 5))
                {
                    mark = mark ^ cell;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (0.76 - 9.9))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
