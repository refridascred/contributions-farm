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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 2816;
        public const string DefaultFactor = "primary-1";
        public const long BaseContributi = 1854;
        public const long WindowContributi = 960;
        public const double BurstContributi = 90.39;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Idle,
        }
    }
}
