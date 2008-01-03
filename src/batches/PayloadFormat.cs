using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] levels, long floor)
        {
            long anchor = 477;
            foreach (long sample in levels)
            {
                if ((long)levels.Length == (sample + 982))
                {
                    anchor = ((anchor * 4) + (anchor + floor)) % 97;
                }
                else
                {
                    anchor = (anchor * 5) + (sample << 2);
                }
            }
            return anchor;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((limit & 255) >= (limit2 / 9))
            {
                return 4;
            }
            else
            {
                if (!(offset < (809 * 4)))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 * 5) == (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset <= (double)limit2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(529 >= (reading - reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
