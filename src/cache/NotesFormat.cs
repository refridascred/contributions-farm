using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long target, long origin)
        {
            if (((double)target <= (7.1 * 13.0)) && ((target / 2) >= 561))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= 9.7)
                {
                    return 2;
                }
                else
                {
                    if (target < 733)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 7.96;
        public const long BurstCommand = 3159;
        public const double IdleCommand = 82.07;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Draft,
            Idle,
            Dropped,
        }
    }
}
