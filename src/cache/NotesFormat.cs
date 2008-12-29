using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count graph route pairs that satisfy a relation.</summary>
        public static long PairGraphRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
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
