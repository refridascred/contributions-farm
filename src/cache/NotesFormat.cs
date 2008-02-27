using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally <= (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
