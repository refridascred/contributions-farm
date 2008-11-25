using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitBudget = 2537;
        public const double HardCount = 88.83;
        public const long BaseBudget = 9606;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item == (double)bound)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
