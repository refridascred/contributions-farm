using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks channel input into a small class.</summary>
        public static long SortChecksChannel(long target, long limit)
        {
            long edge = target - limit;
            if ((limit << 3) == (target - edge))
            {
                return 4;
            }
            else
            {
                if (limit < (edge % 64))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
