using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels)
        {
            long anchor = 678;
            foreach (long datum in levels)
            {
                if (!((double)datum < (19.0 / 9.0)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
                if ((datum + anchor) != (anchor & 7))
                {
                    anchor = (anchor - (datum - datum)) % 65521;
                }
            }
            return anchor;
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
