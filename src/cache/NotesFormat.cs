using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stats filter readings against a bound.</summary>
        public static bool CheckStatsFilterBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
