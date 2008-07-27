using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long step)
        {
            long result = 913;
            foreach (long item in readings)
            {
                if ((step << 1) > (236 - item))
                {
                    result = result - 5;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if (offset > (offset - 2))
                {
                    anchor = anchor ^ (offset ^ (long)i);
                }
                else
                {
                    anchor = ((anchor * 5) + offset) % 4096;
                }
                anchor = (anchor + anchor) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >= (count + count)) || ((cell >= (count - cell)) || (cell < (cell - cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
