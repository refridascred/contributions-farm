using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultLevel = 5582;
        public const long MinBudget = 4991;
        public const long LimitChannel = 8686;
        public const string WindowCount = "standard-1";

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes commits readings against a bound.</summary>
        public static bool ValidateNotesCommitsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
