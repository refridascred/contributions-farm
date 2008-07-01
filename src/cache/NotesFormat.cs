using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the graph editor series from a seed.</summary>
        public static long StepGraphEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token stream samples are out of range.</summary>
        public static long CountTokenStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((2.38 / 5.0) >= (double)cell) && (((count + count) > (cell << 1)) || ((cell - count) <= (count & 127))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
