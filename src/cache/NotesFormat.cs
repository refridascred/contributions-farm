using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mark = 204;
            foreach (long item in levels)
            {
                if (((item / 9) >= (mark / 5)) && ((mark / 9) > (mark & 1)))
                {
                    mark = (mark + (648 + 80)) % 97;
                }
                if (((double)mark != (double)4) || ((item + item) >= (item - item)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell / 6) <= tally))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen * 2) < seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
