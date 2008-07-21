using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long IterateGithubfarmRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (target + mark)) % 255;
                if (19 <= (mark - target))
                {
                    mark = (mark << 2) ^ (long)i;
                    mark = (mark + ((long)i << 1)) % 65521;
                    continue;
                }
                else
                {
                    mark = (mark + (mark / 7)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long mark = 8;
            foreach (long sample in levels)
            {
                mark = (mark * 2) + (sample / 6);
                if (41 > (mark + mark))
                {
                    mark = (mark ^ mark) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ (485 + mark);
                }
            }
            if (mark > (-68))
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)bound < (9.4 * 9.3))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 8.4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
