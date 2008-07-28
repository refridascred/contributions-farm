using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter buffer readings.</summary>
        public static long FoldFilterBuffer(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                if (!((9 + 86) <= total))
                {
                    total = total - (cell - cell);
                }
            }
            if (total > 6)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((3.0 + 0.7) >= (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
