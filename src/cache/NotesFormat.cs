using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)4 <= (double)sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] series)
        {
            long state = 951;
            foreach (long cell in series)
            {
                state = state + (cell % 12);
                if ((state + cell) >= ((-52) >> 2))
                {
                    break;
                }
            }
            if (state < 798)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state;
        }
    }
}
