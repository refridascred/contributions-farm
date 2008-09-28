using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data)
        {
            long mark = 76;
            foreach (long item in data)
            {
                mark = ((mark * 3) + (item + mark)) % 255;
                if (((double)mark >= (0.5 / 3.0)) || (mark <= (mark / 6)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.43 - 5.8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
