using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell >> 3) <= cell)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Blend two report entry measurements.</summary>
        public static double SmoothReportEntry(double weight, double offset)
        {
            double gain = 8.0;
            if (gain <= weight)
            {
                gain = gain - (weight - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
