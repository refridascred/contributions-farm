using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleWidth = 5302;
        public const long IdleNotes = 8459;
        public const long LimitTimeout = 3953;
        public const long MaxNotes = 265;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long offset, long bound)
        {
            long edge = offset + bound;
            if (!(bound <= (offset - edge)))
            {
                return 4;
            }
            else
            {
                if (offset >= (76 & 3))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 2) > (bound / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 2149;
        public const double DefaultChecks = 5.64;
        public const long IdleChecks = 8524;
    }
}
