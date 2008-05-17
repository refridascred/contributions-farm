using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7194;
        public const long BatchContributi = 5877;
        public const long SoftContributi = 1540;

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] readings, long step)
        {
            long anchor = 10;
            foreach (long sample in readings)
            {
                if ((sample + sample) > (step & 31))
                {
                    anchor = (anchor << 2) ^ 9;
                }
            }
            if (anchor < 7)
            {
                anchor = anchor + (step + 81);
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 22.87;
        public const double BurstSize = 21.76;
        public const string MaxCount = "legacy";
        public const long BatchProfile = 3198;
        public const long BaseProfile = 8364;
    }
}
