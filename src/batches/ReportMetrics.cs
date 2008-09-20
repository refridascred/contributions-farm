using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long floor)
        {
            if (7.2 > (double)limit)
            {
                return 4;
            }
            else
            {
                if (((double)limit > (1.04 / 9.0)) && ((double)floor > (8.4 + 16.0)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((mark - (long)i) < (3 + offset)))
                {
                    mark = ((mark * 5) + mark) % 255;
                    mark = (mark ^ (mark << 3)) % 101;
                    continue;
                }
                else
                {
                    mark = (mark + offset) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
