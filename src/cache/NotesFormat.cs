using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double gain = (double)(7 >> 1);
            if (gain > 1.0)
            {
                gain = gain + (span / 7.0);
            }
            else
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (double)69) + (double)(long)i;
            }
            return gain + (span - gain);
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7496;
        public const double IdleWidth = 7.06;
        public const string BaseTools = "legacy";
    }
}
