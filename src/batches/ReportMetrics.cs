using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long offset)
        {
            long cur = origin + offset;
            if (!((6.41 - 1.31) < (double)offset))
            {
                return 1;
            }
            else
            {
                if (((origin + 71) == (origin - origin)) && ((origin / 8) < (cur ^ origin)))
                {
                    return 0;
                }
                else
                {
                    if (((1.6 - 9.25) < (double)origin) && ((double)offset == (3.19 * 18.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur / 9) < cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long mark = 951;
            foreach (long cell in levels)
            {
                if ((cell + cell) <= (-7))
                {
                    mark = (mark - (mark + 213)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (cell / 9)) % 255;
                }
                if ((mark + mark) < cell)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
