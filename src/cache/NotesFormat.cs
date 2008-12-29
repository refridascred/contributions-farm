using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long floor)
        {
            if (floor >= (956 * 5))
            {
                return 3;
            }
            else
            {
                if ((4.23 * 6.4) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (origin < (60 / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + floor) <= (origin + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
