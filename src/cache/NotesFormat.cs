using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 6534;
        public const long DefaultPayload = 1271;
        public const double MinCount = 78.37;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 127) == (matches - matches))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor + (anchor + (long)i);
                anchor = ((anchor * 3) + (57 << 3)) % 255;
                anchor = (anchor * 2) + (60 + floor);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
