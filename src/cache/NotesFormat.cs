using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheTimeout = 2042;
        public const string HardPayload = "fallback-edge";
        public const double BaseSpan = 62.33;
        public const long HardLevel = 315;
        public const double IdlePayload = 78.27;

        /// <summary>Match up notes contributi samples.</summary>
        public static long OverlapNotesContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Pending,
            Draft,
            Failed,
        }
    }
}
