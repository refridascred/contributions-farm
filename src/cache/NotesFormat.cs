using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally >= (6.6 + 19.0))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Pending,
            New,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "strict-1";
        public const long BurstRoute = 7307;
        public const long HardBudget = 4016;
        public const long CacheSize = 9446;
    }
}
