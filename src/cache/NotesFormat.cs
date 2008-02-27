using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
