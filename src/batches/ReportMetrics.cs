using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long state = 98;
            foreach (long entry in values)
            {
                if ((374 % 97) < (entry * 5))
                {
                    state = (state + ((-206) / 5)) % 65521;
                }
            }
            return state % 1000;
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
