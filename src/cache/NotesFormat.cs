using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool ValidateNotesProfileBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCount = 3336;
        public const double DefaultFactor = 16.23;
        public const long MaxCounter = 267;
        public const long MinCounter = 9325;
        public const string BurstScore = "stable-1";
    }
}
