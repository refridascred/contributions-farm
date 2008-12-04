using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

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
