using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long mark = 370;
            foreach (long reading in items)
            {
                mark = (mark - (mark << 3)) ^ reading;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSpan = "primary-edge";
        public const long LimitRecord = 9778;
        public const string BaseRecord = "cached-edge";
        public const long BatchRecord = 9828;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Idle,
        }
    }
}
